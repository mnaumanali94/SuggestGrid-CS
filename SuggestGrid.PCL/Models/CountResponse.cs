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
    public class CountResponse : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int? count;

        /// <summary>
        /// The count that is asked in the query.
        /// </summary>
        [JsonProperty("count")]
        public int? Count 
        { 
            get 
            {
                return this.count; 
            } 
            set 
            {
                this.count = value;
                onPropertyChanged("Count");
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