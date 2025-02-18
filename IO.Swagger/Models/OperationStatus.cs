/*
 * Metering Point API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 0.1.0
 * 
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
          /// Gets or Sets OperationStatus
          /// </summary>
          [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
          public enum OperationStatus
          {
              /// <summary>
              /// Enum UnknownEnum for unknown
              /// </summary>
              [EnumMember(Value = "unknown")]
              UnknownEnum = 0,
              /// <summary>
              /// Enum OkEnum for ok
              /// </summary>
              [EnumMember(Value = "ok")]
              OkEnum = 1,
              /// <summary>
              /// Enum MaintenanceEnum for maintenance
              /// </summary>
              [EnumMember(Value = "maintenance")]
              MaintenanceEnum = 2          }
}
