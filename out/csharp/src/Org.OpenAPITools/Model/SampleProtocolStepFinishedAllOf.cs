/*
 * Sample Life Kafka Topic
 *
 * ## Introduction  This document will describe the messages that can get posted on the `sample-life` kafka topic.  The goal is that multiple applications can communicate with each other through this topic.  Some examples could be: - SLIMS starts a protocol for a certain sample -> SLIMS posts a message on the topic saying the sample has started a protocol -> a dashboard application picks up this message and uses it to display the info to a lab admin - An Agilent scale weighs a certain sample -> posts this result on the kafka topic -> SLIMS picks this up and fills the result value for that sample - ...  ## SLIMS as a producer  To make SLIMS work as a producer a few things are needed: - SLIMSGATE is running - The kafka-sample-life-producer plugin is running - Rules are configured for every workflow context event that trigger the `kafka-sample-life-producer` slimsgate flow.   These rules can have a conditional expression as well that can be customized.  TODO: The plugin and rules could be a SLIMSSHARE package  Certain events in SLIMS will result in a message being posted on the topic. The message will always be a SampleMessage, see the schema for more information. Depending on the event the SampleMessage will contain an event with some extra information about the event. - When a result is filled in for a sample inside a workflow the event object will contain a SampleResult object - When a sample is reduced (derived in SLIMS terminology) within a workflow the event object will contain a SampleReduced object - When a sample is mixed in a workflow the event object will contain a SampleMixed object - When a sample is scheduled in a workflow the event object will contain a SampleScheduled object - When a sample is rescheduled (requeued in SLIMS terminology) in a workflow the event object will contain a SampleRescheduled object - When a sample is cancelled in a workflow the event object will contain a SampleCancelled object - When a flag is added to a sample in a workflow the event object will contain a SampleFlagged object - When a protocol step is started then for every sample within that step a messages is produced and the event object will contain a SampleProtocolStepStarted object - When a protocol step is finished then for every sample within that step a messages is produced and the event object will contain a SampleProtocolStepFinished object - When a protocol is finished then for every sample within that protocol a messages is produced and the event object will contain a SampleProtocolFinished object - When a sample went through the complete workflow the event object will contain a SampleWorkflowFinished object 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// SampleProtocolStepFinishedAllOf
    /// </summary>
    [DataContract]
    public partial class SampleProtocolStepFinishedAllOf :  IEquatable<SampleProtocolStepFinishedAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleProtocolStepFinishedAllOf" /> class.
        /// </summary>
        /// <param name="step">step.</param>
        public SampleProtocolStepFinishedAllOf(string step = default(string))
        {
            this.Step = step;
        }

        /// <summary>
        /// Gets or Sets Step
        /// </summary>
        [DataMember(Name="step", EmitDefaultValue=false)]
        public string Step { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SampleProtocolStepFinishedAllOf {\n");
            sb.Append("  Step: ").Append(Step).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SampleProtocolStepFinishedAllOf);
        }

        /// <summary>
        /// Returns true if SampleProtocolStepFinishedAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleProtocolStepFinishedAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleProtocolStepFinishedAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Step == input.Step ||
                    (this.Step != null &&
                    this.Step.Equals(input.Step))
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
                int hashCode = 41;
                if (this.Step != null)
                    hashCode = hashCode * 59 + this.Step.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
