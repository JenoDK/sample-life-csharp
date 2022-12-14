/*
 * Sample Life Kafka Topic
 *
 * ## Introduction  This document will describe the messages that can get posted on the `sample-life` kafka topic.  The goal is that multiple applications can communicate with each other through this topic.  Some examples could be: - SLIMS starts a protocol for a certain sample -> SLIMS posts a message on the topic saying the sample has started a protocol -> a dashboard application picks up this message and uses it to display the info to a lab admin - An Agilent scale weighs a certain sample -> posts this result on the kafka topic -> SLIMS picks this up and fills the result value for that sample - ...  ## SLIMS as a producer  To make SLIMS work as a producer a few things are needed: - SLIMSGATE is running - The kafka-sample-life-producer plugin is running - Rules are configured for every workflow context event that trigger the `kafka-sample-life-producer` slimsgate flow.   These rules can have a conditional expression as well that can be customized.  TODO: The plugin and rules could be a SLIMSSHARE package  Certain events in SLIMS will result in a message being posted on the topic. The message will always be a SampleMessage, see the schema for more information. Depending on the event the SampleMessage will contain an event with some extra information about the event. - When a result is filled in for a sample inside a workflow the event object will contain a SampleResult object - When a sample is reduced (derived in SLIMS terminology) within a workflow the event object will contain a SampleReduced object - When a sample is mixed in a workflow the event object will contain a SampleMixed object - When a sample is scheduled in a workflow the event object will contain a SampleScheduled object - When a sample is rescheduled (requeued in SLIMS terminology) in a workflow the event object will contain a SampleRescheduled object - When a sample is cancelled in a workflow the event object will contain a SampleCancelled object - When a flag is added to a sample in a workflow the event object will contain a SampleFlagged object - When a protocol step is started then for every sample within that step a messages is produced and the event object will contain a SampleProtocolStepStarted object - When a protocol step is finished then for every sample within that step a messages is produced and the event object will contain a SampleProtocolStepFinished object - When a protocol is finished then for every sample within that protocol a messages is produced and the event object will contain a SampleProtocolFinished object - When a sample went through the complete workflow the event object will contain a SampleWorkflowFinished object 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System.Collections.Generic;

namespace Org.OpenAPITools.Client
{
    /// <summary>
    /// Represents a readable-only configuration contract.
    /// </summary>
    public interface IReadableConfiguration
    {
        /// <summary>
        /// Gets the access token.
        /// </summary>
        /// <value>Access token.</value>
        string AccessToken { get; }

        /// <summary>
        /// Gets the API key.
        /// </summary>
        /// <value>API key.</value>
        IDictionary<string, string> ApiKey { get; }

        /// <summary>
        /// Gets the API key prefix.
        /// </summary>
        /// <value>API key prefix.</value>
        IDictionary<string, string> ApiKeyPrefix { get; }

        /// <summary>
        /// Gets the base path.
        /// </summary>
        /// <value>Base path.</value>
        string BasePath { get; }

        /// <summary>
        /// Gets the date time format.
        /// </summary>
        /// <value>Date time format.</value>
        string DateTimeFormat { get; }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <value>Default header.</value>
        IDictionary<string, string> DefaultHeader { get; }

        /// <summary>
        /// Gets the temp folder path.
        /// </summary>
        /// <value>Temp folder path.</value>
        string TempFolderPath { get; }

        /// <summary>
        /// Gets the HTTP connection timeout (in milliseconds)
        /// </summary>
        /// <value>HTTP connection timeout.</value>
        int Timeout { get; }

        /// <summary>
        /// Gets the user agent.
        /// </summary>
        /// <value>User agent.</value>
        string UserAgent { get; }

        /// <summary>
        /// Gets the username.
        /// </summary>
        /// <value>Username.</value>
        string Username { get; }

        /// <summary>
        /// Gets the password.
        /// </summary>
        /// <value>Password.</value>
        string Password { get; }

        /// <summary>
        /// Gets the API key with prefix.
        /// </summary>
        /// <param name="apiKeyIdentifier">API key identifier (authentication scheme).</param>
        /// <returns>API key with prefix.</returns>
        string GetApiKeyWithPrefix(string apiKeyIdentifier);
    }
}
