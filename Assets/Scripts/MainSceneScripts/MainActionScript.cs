using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using UnityEngine.SceneManagement;

public class MainActionScript : MonoBehaviour
{
    public Button FirstButton;
    public Button SecondButton;
    public Button ThirdButton;
    public Button FourthButton;

    public static bool isThereSelection = false;

    public static int rightGuessedCountries = 0;

    public static string countryName;


    public static StringBuilder prevCountries = new StringBuilder();
    public static string[] prevCountriesArray = new string[10000];

    public static bool isFirstTime = true;


    void Update()
    {
        if (isThereSelection == false)
        {

            if(isFirstTime)
            {
                rightGuessedCountries = 0;
                TimeDetectionScript.milisec = 0;
                TimeDetectionScript.sec = 0;
                TimeDetectionScript.min = 0;
                TimeDetectionScript.hour = 0;
                TimeDetectionScript.absTime = "";
                isFirstTime = false;
            }

            string nameArray = "Russia/Ukraine/Belarus/Finland/Estonia" +
                     "/Sweden/Norway/Denmark/Iceland/Ireland" +
                     "/United Kingdom/Andorra/Latvia/Lithuania/Poland" +
                     "/Germany/Belgium/Luxembourg/Liechtenstein/France" +
                     "/Spain/Portugal/Switzerland/Austria/Czech Republic" +
                     "/Slovenia/Slovakia/Malta/San Marino/Cyprus" +
                     "/Monaco/Vatican/Hungary/Croatia/Moldova" +
                     "/Romania/Bulgaria/North Macedonia/Greece/Albania" +
                     "/Kosovo/Bosnia and Herzegovina/Serbia/Montenegro/Italy/Netherlands" +
                     "/Greenland/Transnistria/Turkey/Syria/Lebanon/Abkhazia/Armenia/Azerbaijan/Artsakh" +
                     "/South Ossetia/Georgia/Iran/Iraq/Jordan/Palestine/Israel/Northern Cyprus" +
                     "/Saudi Arabia/Bahrain/Qatar/Kuwait/United Arab Emirates/Oman/Yemen/Afghanistan" +
                     "/Pakistan/India/Uzbekistan/Turkmenistan/Kazakhstan/Kyrgyzstan/Tajikistan/Mongolia/Maldives/Sri Lanka" +
                     "/Myanmar/Bangladesh/Nepal/Bhutan/China/Laos/Thailand/Cambodia/Vietnam/Japan/South Korea/North Korea" +
                     "/Taiwan/Malaysia/Singapore/Indonesia/Philippines/Brunei/Papua New Guinea/East Timor/Australia/New Zealand" +
                     "/Morocco/Algeria/Tunisia/Libya/Egypt/Sudan/South Sudan/Eritrea/Djibouti/Ethiopia/Mali/Chad/Niger/Nigeria" +
                     "/Western Sahara/Mauritania/Guinea/Guinea-Bissau/The Gambia/Liberia/Sierra Leone/Senegal/Ivory Coast/Ghana" +
                     "/Togo/Burkina Faso/Cape Verde/Benin/Cameroon/Gabon/Equatorial Guinea/Sao Tome and Principe/Republic of the Congo" +
                     "/Democratic Republic of the Congo/Central African Republic/Kenya/Uganda/Rwanda/Burundi/Somalia/Somaliland" +
                     "/Tanzania/Zambia/Angola/Malawi/Mozambique/Zimbabwe/Comoros/Mauritius/Seychelles/Namibia/Botswana" +
                     "/South Africa/Lesotho/Eswatini/Madagascar/Brazil/Paraguay/Uruguay/Argentina/Chile/Bolivia/Peru/Ecuador" +
                     "/Colombia/Venezuela/Suriname/Guyana/Panama/Costa Rica/Nicaragua/Honduras/El Salvador/Guatemala/Belize/Jamaica" +
                     "/Haiti/Dominica/Dominican Republic/Cuba/Mexico/United States/Canada/Puerto Rico/Cayman islands/Bahamas" +
                     "/Turks and Caicos islands/US Virgin islands/British Virgin islands/Anguilla/Antigua and Barbuda/Montserrat" +
                     "/Saint Kitts and Nevis/Guadeloupe/Martinique/Saint Lucia/Saint Vincent and the Grenadines/Grenada/Barbados" +
                     "/Trinidad and Tobago/Aruba/Curacao/Bonaire/Northern Mariana islands/Guam/Marshall islands/Palau/Nauru" +
                     "/Federated States of Micronesia/Solomon islands/New Caledonia/Vanuatu/Tuvalu/Fiji/Tonga/Niue/Wallis and Futuna" +
                     "/Samoa/American Samoa/Tokelau/Kiribati/Pitcairn islands/Cook islands/French Polynesia/Aland islands/Alaska" +
                     "/Alderney/Aleutian islands/Altai Republic/Ambazonia/Andaman and Nicobar islands/Antarctica/Azores/Basque Country" +
                     "/Bermuda/Bougainville/British Antarctic Territory/British Indian Ocean Territory/Brittany/Canary islands/Catalonia" +
                     "/Chechnya/Christmas island/Chukotka/Chuvashia/Cocos islands/Crete/Crimea/Dagestan/Darfur/Donetsk People's Republic" +
                     "/England/Evenkia/Falkland islands/Faroe islands/French Southern and Antarctic Lands/Galapagos islands/Galicia" +
                     "/Gibraltar/Guernsey/Hawaii/Hong Kong/Ingushetia/Isle of Man/Jammu and Kashmir/Jersey/Kalmykia/Kamchatka/Karakalpakstan" +
                     "/Karelia/Komi/Koryak/Kuban People's Republic/Kurdistan/Ladonia/Lugansk People's Republic/Macau/Mayotte/Midway islands" +
                     "/Mordovia/Nakhichevan/Newfoundland/Norfolk island/North Borneo/North Sulawesi/Northern Ireland/Quebec/Rapa Nui" +
                     "/Reunion/Saint Barthelemy/Saint Helena, Ascension and Tristan da Cunha/Saint Pierre and Miquelon/Sakha Republic" +
                     "/Sark/Scotland/Skane/South Georgia and the South Sandwich Islands/South Sulawesi/Tatarstan/Taymir/Tibet" +
                     "/Tuamotu Archipelago/Tuva/Udmurtia/Uhtua/Uyghurstan/Wales/West Papua/West Timor/Yamal-Nenets/Zanzibar";

            ////314 countries

            string[] splitedNameArray = nameArray.Split('/');
            StringBuilder buttonedCountries = new StringBuilder();
            string[] buttonedCountriesArray;
            string chosenCountry;

            CountryNameCheck:

            countryName = splitedNameArray[Random.Range(0, splitedNameArray.Length)];

            prevCountriesArray = prevCountries.ToString().Split('/');

            for (int i = 0; i < prevCountriesArray.Length; i++)
            {
                if(countryName == prevCountriesArray[i])
                {
                    countryName = "";
                    goto CountryNameCheck;
                }
            }

            prevCountries.Append(countryName + '/');

            // print(countryName);

            TeleportFlags();

            buttonedCountries.Append(countryName + '/');

            int decisionIndex = Random.Range(1, 5);

            if (decisionIndex == 1)////1111
            {
                GameObject.Find("FirstButton").GetComponentInChildren<Text>().text = countryName;
            }
            else
            {
                chosenCountry = splitedNameArray[Random.Range(0, splitedNameArray.Length)];
                GameObject.Find("FirstButton").GetComponentInChildren<Text>().text = chosenCountry;
                buttonedCountries.Append(chosenCountry + '/');
                chosenCountry = "";
            }


            if (decisionIndex == 2)/////22222
            {
                GameObject.Find("SecondButton").GetComponentInChildren<Text>().text = countryName;
            }
            else
            {
                SecondButton:

                chosenCountry = splitedNameArray[Random.Range(0, splitedNameArray.Length)];


                buttonedCountriesArray = buttonedCountries.ToString().Split('/');

                for (int i = 0; i < buttonedCountriesArray.Length; i++)
                {
                    if (chosenCountry == buttonedCountriesArray[i])
                    {
                        chosenCountry = "";
                        goto SecondButton;
                    }
                }


                GameObject.Find("SecondButton").GetComponentInChildren<Text>().text = chosenCountry;
                buttonedCountries.Append(chosenCountry + '/');
                chosenCountry = "";
            }


            if (decisionIndex == 3)////3333
            {
                GameObject.Find("ThirdButton").GetComponentInChildren<Text>().text = countryName;
            }
            else
            {
            ThirdButton:

                chosenCountry = splitedNameArray[Random.Range(0, splitedNameArray.Length)];

                buttonedCountriesArray = buttonedCountries.ToString().Split('/');

                for (int i = 0; i < buttonedCountriesArray.Length; i++)
                {
                    if (chosenCountry == buttonedCountriesArray[i])
                    {
                        chosenCountry = "";
                        goto ThirdButton;
                    }
                }

                GameObject.Find("ThirdButton").GetComponentInChildren<Text>().text = chosenCountry;
                buttonedCountries.Append(chosenCountry + '/');
                chosenCountry = "";
            }


            if (decisionIndex == 4)////4444
            {
                GameObject.Find("FourthButton").GetComponentInChildren<Text>().text = countryName;
            }
            else
            {
            FourthButton:

                chosenCountry = splitedNameArray[Random.Range(0, splitedNameArray.Length)];

                buttonedCountriesArray = buttonedCountries.ToString().Split('/');

                for (int i = 0; i < buttonedCountriesArray.Length; i++)
                {
                    if (chosenCountry == buttonedCountriesArray[i])
                    {
                        chosenCountry = "";
                        goto FourthButton;
                    }
                }

                GameObject.Find("FourthButton").GetComponentInChildren<Text>().text = chosenCountry;
                buttonedCountries.Append(chosenCountry + '/');
                chosenCountry = "";
            }

            isThereSelection = true;
        }   
    }


    public static Vector3 prevFlagPos;
    public static Vector3 unPos = new Vector3(0, 3, 0);

    public void TeleportFlags()
    {
            //print(prevCountriesArray.Length);
            prevFlagPos = GameObject.Find(countryName).transform.position;
            GameObject.Find(countryName).transform.position = unPos;
    }

}
