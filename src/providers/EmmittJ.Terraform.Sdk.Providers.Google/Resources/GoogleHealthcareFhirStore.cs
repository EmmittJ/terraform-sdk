using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for notification_config in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class GoogleHealthcareFhirStoreNotificationConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The Cloud Pub/Sub topic that notifications of changes are published on. Supplied by the client.
    /// PubsubMessage.Data will contain the resource name. PubsubMessage.MessageId is the ID of this message.
    /// It is guaranteed to be unique within the topic. PubsubMessage.PublishTime is the time at which the message
    /// was published. Notifications are only sent if the topic is non-empty. Topic names must be scoped to a
    /// project. service-PROJECT_NUMBER@gcp-sa-healthcare.iam.gserviceaccount.com must have publisher permissions on the given
    /// Cloud Pub/Sub topic. Not having adequate permissions will cause the calls that send notifications to fail.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PubsubTopic is required")]
    [TerraformProperty("pubsub_topic")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PubsubTopic { get; set; }

}

/// <summary>
/// Block type for notification_configs in .
/// Nesting mode: list
/// </summary>
public partial class GoogleHealthcareFhirStoreNotificationConfigsBlock : TerraformBlockBase
{
    /// <summary>
    /// The Cloud Pub/Sub topic that notifications of changes are published on. Supplied by the client.
    /// PubsubMessage.Data will contain the resource name. PubsubMessage.MessageId is the ID of this message.
    /// It is guaranteed to be unique within the topic. PubsubMessage.PublishTime is the time at which the message
    /// was published. Notifications are only sent if the topic is non-empty. Topic names must be scoped to a
    /// project. service-PROJECT_NUMBER@gcp-sa-healthcare.iam.gserviceaccount.com must have publisher permissions on the given
    /// Cloud Pub/Sub topic. Not having adequate permissions will cause the calls that send notifications to fail.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PubsubTopic is required")]
    [TerraformProperty("pubsub_topic")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PubsubTopic { get; set; }

    /// <summary>
    /// Whether to send full FHIR resource to this Pub/Sub topic for Create and Update operation.
    /// Note that setting this to true does not guarantee that all resources will be sent in the format of
    /// full FHIR resource. When a resource change is too large or during heavy traffic, only the resource name will be
    /// sent. Clients should always check the &amp;quot;payloadType&amp;quot; label from a Pub/Sub message to determine whether
    /// it needs to fetch the full resource as a separate operation.
    /// </summary>
    [TerraformProperty("send_full_resource")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SendFullResource { get; set; }

    /// <summary>
    /// Whether to send full FHIR resource to this Pub/Sub topic for deleting FHIR resource. Note that setting this to
    /// true does not guarantee that all previous resources will be sent in the format of full FHIR resource. When a
    /// resource change is too large or during heavy traffic, only the resource name will be sent. Clients should always
    /// check the &amp;quot;payloadType&amp;quot; label from a Pub/Sub message to determine whether it needs to fetch the full previous
    /// resource as a separate operation.
    /// </summary>
    [TerraformProperty("send_previous_resource_on_delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SendPreviousResourceOnDelete { get; set; }

}

/// <summary>
/// Block type for stream_configs in .
/// Nesting mode: list
/// </summary>
public partial class GoogleHealthcareFhirStoreStreamConfigsBlock : TerraformBlockBase
{
    /// <summary>
    /// Supply a FHIR resource type (such as &amp;quot;Patient&amp;quot; or &amp;quot;Observation&amp;quot;). See
    /// https://www.hl7.org/fhir/valueset-resource-types.html for a list of all FHIR resource types. The server treats
    /// an empty list as an intent to stream all the supported resource types in this FHIR store.
    /// </summary>
    [TerraformProperty("resource_types")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ResourceTypes { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleHealthcareFhirStoreTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for validation_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleHealthcareFhirStoreValidationConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Whether to disable FHIRPath validation for incoming resources. The default value is false. Set this to true to disable checking incoming resources for conformance against FHIRPath requirement defined in the FHIR specification. This property only affects resource types that do not have profiles configured for them, any rules in enabled implementation guides will still be enforced.
    /// </summary>
    [TerraformProperty("disable_fhirpath_validation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableFhirpathValidation { get; set; }

    /// <summary>
    /// Whether to disable profile validation for this FHIR store. The default value is false. Set this to true to disable checking incoming resources for conformance against structure definitions in this FHIR store.
    /// </summary>
    [TerraformProperty("disable_profile_validation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableProfileValidation { get; set; }

    /// <summary>
    /// Whether to disable reference type validation for incoming resources. The default value is false. Set this to true to disable checking incoming resources for conformance against reference type requirement defined in the FHIR specification. This property only affects resource types that do not have profiles configured for them, any rules in enabled implementation guides will still be enforced.
    /// </summary>
    [TerraformProperty("disable_reference_type_validation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableReferenceTypeValidation { get; set; }

    /// <summary>
    /// Whether to disable required fields validation for incoming resources. The default value is false. Set this to true to disable checking incoming resources for conformance against required fields requirement defined in the FHIR specification. This property only affects resource types that do not have profiles configured for them, any rules in enabled implementation guides will still be enforced.
    /// </summary>
    [TerraformProperty("disable_required_field_validation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableRequiredFieldValidation { get; set; }

    /// <summary>
    /// A list of implementation guide URLs in this FHIR store that are used to configure the profiles to use for validation.
    /// When a URL cannot be resolved (for example, in a type assertion), the server does not return an error.
    /// For example, to use the US Core profiles for validation, set enabledImplementationGuides to [&amp;quot;http://hl7.org/fhir/us/core/ImplementationGuide/ig&amp;quot;]. If enabledImplementationGuides is empty or omitted, then incoming resources are only required to conform to the base FHIR profiles. Otherwise, a resource must conform to at least one profile listed in the global property of one of the enabled ImplementationGuides.
    /// The Cloud Healthcare API does not currently enforce all of the rules in a StructureDefinition. The following rules are supported:
    /// - min/max
    /// - minValue/maxValue
    /// - maxLength
    /// - type
    /// - fixed[x]
    /// - pattern[x] on simple types
    /// - slicing, when using &amp;quot;value&amp;quot; as the discriminator type
    /// </summary>
    [TerraformProperty("enabled_implementation_guides")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? EnabledImplementationGuides { get; set; }

}

/// <summary>
/// Manages a google_healthcare_fhir_store resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleHealthcareFhirStore : TerraformResource
{
    public GoogleHealthcareFhirStore(string name) : base("google_healthcare_fhir_store", name)
    {
    }

    /// <summary>
    /// Enable parsing of references within complex FHIR data types such as Extensions. If this value is set to ENABLED, then features like referential integrity and Bundle reference rewriting apply to all references. If this flag has not been specified the behavior of the FHIR store will not change, references in complex data types will not be parsed. New stores will have this value set to ENABLED by default after a notification period. Warning: turning on this flag causes processing existing resources to fail if they contain references to non-existent resources. Possible values: [&amp;quot;COMPLEX_DATA_TYPE_REFERENCE_PARSING_UNSPECIFIED&amp;quot;, &amp;quot;DISABLED&amp;quot;, &amp;quot;ENABLED&amp;quot;]
    /// </summary>
    [TerraformProperty("complex_data_type_reference_parsing")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ComplexDataTypeReferenceParsing { get; set; }

    /// <summary>
    /// Identifies the dataset addressed by this request. Must be in the format
    /// &#39;projects/{project}/locations/{location}/datasets/{dataset}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    [TerraformProperty("dataset")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Dataset { get; set; }

    /// <summary>
    /// If true, overrides the default search behavior for this FHIR store to handling=strict which returns an error for unrecognized search parameters.
    /// If false, uses the FHIR specification default handling=lenient which ignores unrecognized search parameters.
    /// The handling can always be changed from the default on an individual API call by setting the HTTP header Prefer: handling=strict or Prefer: handling=lenient.
    /// </summary>
    [TerraformProperty("default_search_handling_strict")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DefaultSearchHandlingStrict { get; set; }

    /// <summary>
    /// Whether to disable referential integrity in this FHIR store. This field is immutable after FHIR store
    /// creation. The default value is false, meaning that the API will enforce referential integrity and fail the
    /// requests that will result in inconsistent state in the FHIR store. When this field is set to true, the API
    /// will skip referential integrity check. Consequently, operations that rely on references, such as
    /// Patient.get$everything, will not return all the results if broken references exist.
    /// 
    /// ** Changing this property may recreate the FHIR store (removing all data) **
    /// </summary>
    [TerraformProperty("disable_referential_integrity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableReferentialIntegrity { get; set; }

    /// <summary>
    /// Whether to disable resource versioning for this FHIR store. This field can not be changed after the creation
    /// of FHIR store. If set to false, which is the default behavior, all write operations will cause historical
    /// versions to be recorded automatically. The historical versions can be fetched through the history APIs, but
    /// cannot be updated. If set to true, no historical versions will be kept. The server will send back errors for
    /// attempts to read the historical versions.
    /// 
    /// ** Changing this property may recreate the FHIR store (removing all data) **
    /// </summary>
    [TerraformProperty("disable_resource_versioning")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableResourceVersioning { get; set; }

    /// <summary>
    /// Whether to allow the bulk import API to accept history bundles and directly insert historical resource
    /// versions into the FHIR store. Importing resource histories creates resource interactions that appear to have
    /// occurred in the past, which clients may not want to allow. If set to false, history bundles within an import
    /// will fail with an error.
    /// 
    /// ** Changing this property may recreate the FHIR store (removing all data) **
    /// 
    /// ** This property can be changed manually in the Google Cloud Healthcare admin console without recreating the FHIR store **
    /// </summary>
    [TerraformProperty("enable_history_import")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableHistoryImport { get; set; }

    /// <summary>
    /// Whether this FHIR store has the updateCreate capability. This determines if the client can use an Update
    /// operation to create a new resource with a client-specified ID. If false, all IDs are server-assigned through
    /// the Create operation and attempts to Update a non-existent resource will return errors. Please treat the audit
    /// logs with appropriate levels of care if client-specified resource IDs contain sensitive data such as patient
    /// identifiers, those IDs will be part of the FHIR resource path recorded in Cloud audit logs and Cloud Pub/Sub
    /// notifications.
    /// </summary>
    [TerraformProperty("enable_update_create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnableUpdateCreate { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// User-supplied key-value pairs used to organize FHIR stores.
    /// 
    /// Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must
    /// conform to the following PCRE regular expression: [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62}
    /// 
    /// Label values are optional, must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128
    /// bytes, and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}\p{N}_-]{0,63}
    /// 
    /// No more than 64 labels can be associated with a given store.
    /// 
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs.
    /// Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The resource name for the FhirStore.
    /// 
    /// ** Changing this property may recreate the FHIR store (removing all data) **
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The FHIR specification version. Possible values: [&amp;quot;DSTU2&amp;quot;, &amp;quot;STU3&amp;quot;, &amp;quot;R4&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Version { get; set; }

    /// <summary>
    /// Block for notification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfig block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("notification_config")]
    public partial TerraformList<TerraformBlock<GoogleHealthcareFhirStoreNotificationConfigBlock>>? NotificationConfig { get; set; }

    /// <summary>
    /// Block for notification_configs.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("notification_configs")]
    public partial TerraformList<TerraformBlock<GoogleHealthcareFhirStoreNotificationConfigsBlock>>? NotificationConfigs { get; set; }

    /// <summary>
    /// Block for stream_configs.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("stream_configs")]
    public partial TerraformList<TerraformBlock<GoogleHealthcareFhirStoreStreamConfigsBlock>>? StreamConfigs { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleHealthcareFhirStoreTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for validation_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ValidationConfig block(s) allowed")]
    [TerraformProperty("validation_config")]
    public partial TerraformList<TerraformBlock<GoogleHealthcareFhirStoreValidationConfigBlock>>? ValidationConfig { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The fully qualified name of this dataset
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
