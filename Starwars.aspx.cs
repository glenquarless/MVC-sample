using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using System.Diagnostics;
using Newtonsoft.Json;
using System.IO;

namespace IAmTheLastJedi
{
    public partial class About : Page
    {
        string peoplefile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "resources\\People.json");
        People everyone = null;

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                everyone = GetPeople();
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }

        protected void btnRun_Click(object sender, EventArgs e)
        {

            try
            {
                DeserialiseJSON();
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }

        public void DeserialiseJSON()
        {

            try
            {
                everyone = GetPeople();

                gvPeople.DataSource = everyone.results;
                gvPeople.DataBind();

            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }

        protected void gvPeople_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                PopulatePerson(gvPeople.SelectedIndex);
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }

        protected void PopulatePerson(int _index)
        {
            Person someone = null;

            try
            {
                // get person details
                someone = everyone.results[_index];

                // populate details
                dvPersonDetails.Visible = true;

                PopulateScreen(someone);            
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }

        public void PopulateScreen(Person _guy)
        {
            try
            {
                txtName.Text = _guy.name;
                txtHeight.Text = _guy.height;
                txtMass.Text = _guy.mass;
                txtHairColour.Text = _guy.hair_color;
                txtEyeColour.Text = _guy.eye_color;
                txtSkinColour.Text = _guy.skin_color;
                txtBirthYear.Text = _guy.birth_year;
                txtGender.Text = _guy.gender;
                txtHomeWorld.Text = _guy.homeworld;

                txtCreated.Text = _guy.created;
                txtEdited.Text = _guy.edited;
                txtUrl.Text = _guy.url;

                txtFilms.Text = GetStringFromArray(_guy.films);
                txtSpecies.Text = GetStringFromArray(_guy.species);
                txtVehicles.Text = GetStringFromArray(_guy.species);
                txtStarships.Text = GetStringFromArray(_guy.starships);
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }

        protected string GetStringFromArray(string[] _str)
        {
            // give it default value in case the parameter is empty
            string strout = "";

            try
            {
                if (_str != null && _str.Length > 0)
                { 
                    foreach (string str in _str)
                    {
                        strout += str + Environment.NewLine;
                    }
                }
            }
            catch(Exception ex)
            {
                HandleError(ex);
            }
            return strout;
        }

        protected People GetPeople()
        {
            People peeps = null;

            try
            {
                using (StreamReader sr = new StreamReader(peoplefile))
                {
                    peeps = JsonConvert.DeserializeObject<People>(sr.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
            return peeps;
        }

        public void HandleError(Exception ex)
        {
            // standard error handler which in this case is just pulling a bit of detail from the exception and writing to the output window
            string strerror = string.Empty, 
                strerrorformat = "Error occurred: {0} Message: {1} {2} Stack trace: {3}";

            try
            {
                strerror = string.Format(strerrorformat, 
                                         Environment.NewLine , ex.Message, Environment.NewLine, ex.StackTrace);
                Debug.Print(strerror);
            }
            catch (Exception exex)
            {
                Debug.Print(exex.Message);
            }
        }
    }
}