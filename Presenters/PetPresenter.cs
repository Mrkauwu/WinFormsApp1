﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;
using WinFormsApp1.Views;
using static Azure.Core.HttpHeader;

namespace WinFormsApp1.Presenters
{
    public class PetPresenter
    {
        //Fields
        private IPetView view;
        private IPetRepository repository;
        private BindingSource petsBindingSource;
        private IEnumerable<PetModel> petList;

        //Constructor
        public PetPresenter(IPetView view, IPetRepository repository)
        {
            this.petsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            //Subscribe event handler methods to view events
            this.view.SearchEvent += SearchPet;
            this.view.AddNewEvent += AddNewPet;
            this.view.EditEvent += LoadSelectedPetToEdit;
            this.view.DeleteEvent += DeleteSelectedPet;
            this.view.SaveEvent += SavePet;
            this.view.CancelEvent += CancelAction;
            //Set pets bindind source
            this.view.SetPetListBindingSource(petsBindingSource);
            //Load pet list view
            LoadAllPetList();
            //Show view
            this.view.Show();
        }

        //Methods
        private void LoadAllPetList()
        {
            petList = repository.GetAll();
            petsBindingSource.DataSource = petList;//Set data source.
        }
        private void SearchPet(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
                petList = repository.GetByValue(this.view.SearchValue);
            else petList = repository.GetAll();
            petsBindingSource.DataSource = petList;
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void CleanviewFields()
        {
            view.PetId = "0";
            view.PetName = "";
            view.PetType = "";
            view.PetColour = "";
        }

        private void SavePet(object sender, EventArgs e)
        {
            var model = new PetModel();
            model.Id = Convert.ToInt32(view.PetId);
            model.Name = view.PetName;
            model.Type = view.PetType;
            model.Colour = view.PetColour;
            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit)//Edit model
                {
                    repository.Edit(model);
                    view.Message = "Pet edited successfuly";
                }
                else //Add new model
                {
                    repository.Add(model);
                    view.Message = "Pet added sucessfully";
                }
                view.IsSuccessful = true;
                LoadAllPetList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }

        }

        private void DeleteSelectedPet(object sender, EventArgs e)
        {
            try
            {
                var pet = (PetModel)petsBindingSource.Current;
                repository.Delete(pet.Id);
                view.IsSuccessful = true;
                view.Message = "Pet deleted successfully";
                LoadAllPetList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete pet";
            }
        }
        private void LoadSelectedPetToEdit(object sender, EventArgs e)
        {
            var pet = (PetModel)petsBindingSource.Current;
            view.PetId = pet.Id.ToString();
            view.PetName = pet.Name;
            view.PetType = pet.Type;
            view.PetColour = pet.Colour;
            view.IsEdit = true;
        }
        private void AddNewPet(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }
}
