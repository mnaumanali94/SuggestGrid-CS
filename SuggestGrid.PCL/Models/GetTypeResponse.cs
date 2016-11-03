/*
 * SuggestGrid.PCL
 *
 * This file was automatically generated for SuggestGrid by APIMATIC v2.0 ( https://apimatic.io ) on 11/03/2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SuggestGrid;

namespace SuggestGrid.Models
{
    public class GetTypeResponse : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string rating;

        /// <summary>
        /// Rating type of the type that is either implicit or explicit.
        /// </summary>
        [JsonProperty("rating")]
        public string Rating 
        { 
            get 
            {
                return this.rating; 
            } 
            set 
            {
                this.rating = value;
                onPropertyChanged("Rating");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 