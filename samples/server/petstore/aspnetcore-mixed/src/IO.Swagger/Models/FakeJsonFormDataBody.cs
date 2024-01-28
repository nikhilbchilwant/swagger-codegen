/*
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class FakeJsonFormDataBody : IEquatable<FakeJsonFormDataBody>
    { 
        /// <summary>
        /// field1
        /// </summary>
        /// <value>field1</value>
        [Required]

        [DataMember(Name="param")]
        public string Param { get; set; }

        /// <summary>
        /// field2
        /// </summary>
        /// <value>field2</value>
        [Required]

        [DataMember(Name="param2")]
        public string Param2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FakeJsonFormDataBody {\n");
            sb.Append("  Param: ").Append(Param).Append("\n");
            sb.Append("  Param2: ").Append(Param2).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((FakeJsonFormDataBody)obj);
        }

        /// <summary>
        /// Returns true if FakeJsonFormDataBody instances are equal
        /// </summary>
        /// <param name="other">Instance of FakeJsonFormDataBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FakeJsonFormDataBody other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Param == other.Param ||
                    Param != null &&
                    Param.Equals(other.Param)
                ) && 
                (
                    Param2 == other.Param2 ||
                    Param2 != null &&
                    Param2.Equals(other.Param2)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Param != null)
                    hashCode = hashCode * 59 + Param.GetHashCode();
                    if (Param2 != null)
                    hashCode = hashCode * 59 + Param2.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(FakeJsonFormDataBody left, FakeJsonFormDataBody right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FakeJsonFormDataBody left, FakeJsonFormDataBody right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}