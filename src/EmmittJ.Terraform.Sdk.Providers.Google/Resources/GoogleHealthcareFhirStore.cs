using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for notification_config in .
/// Nesting mode: list
/// </summary>
public class GoogleHealthcareFhirStoreNotificationConfigBlock : TerraformBlock
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
    public required TerraformProperty<string> PubsubTopic
    {
        get => GetRequiredProperty<TerraformProperty<string>>("pubsub_topic");
        set => WithProperty("pubsub_topic", value);
    }

}

/// <summary>
/// Block type for notification_configs in .
/// Nesting mode: list
/// </summary>
public class GoogleHealthcareFhirStoreNotificationConfigsBlock : TerraformBlock
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
    public required TerraformProperty<string> PubsubTopic
    {
        get => GetRequiredProperty<TerraformProperty<string>>("pubsub_topic");
        set => WithProperty("pubsub_topic", value);
    }

    /// <summary>
    /// Whether to send full FHIR resource to this Pub/Sub topic for Create and Update operation.
    /// Note that setting this to true does not guarantee that all resources will be sent in the format of
    /// full FHIR resource. When a resource change is too large or during heavy traffic, only the resource name will be
    /// sent. Clients should always check the &amp;quot;payloadType&amp;quot; label from a Pub/Sub message to determine whether
    /// it needs to fetch the full resource as a separate operation.
    /// </summary>
    public TerraformProperty<bool>? SendFullResource
    {
        get => GetProperty<TerraformProperty<bool>>("send_full_resource");
        set => WithProperty("send_full_resource", value);
    }

    /// <summary>
    /// Whether to send full FHIR resource to this Pub/Sub topic for deleting FHIR resource. Note that setting this to
    /// true does not guarantee that all previous resources will be sent in the format of full FHIR resource. When a
    /// resource change is too large or during heavy traffic, only the resource name will be sent. Clients should always
    /// check the &amp;quot;payloadType&amp;quot; label from a Pub/Sub message to determine whether it needs to fetch the full previous
    /// resource as a separate operation.
    /// </summary>
    public TerraformProperty<bool>? SendPreviousResourceOnDelete
    {
        get => GetProperty<TerraformProperty<bool>>("send_previous_resource_on_delete");
        set => WithProperty("send_previous_resource_on_delete", value);
    }

}

/// <summary>
/// Block type for stream_configs in .
/// Nesting mode: list
/// </summary>
public class GoogleHealthcareFhirStoreStreamConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Supply a FHIR resource type (such as &amp;quot;Patient&amp;quot; or &amp;quot;Observation&amp;quot;). See
    /// https://www.hl7.org/fhir/valueset-resource-types.html for a list of all FHIR resource types. The server treats
    /// an empty list as an intent to stream all the supported resource types in this FHIR store.
    /// </summary>
    public List<TerraformProperty<string>>? ResourceTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("resource_types");
        set => WithProperty("resource_types", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleHealthcareFhirStoreTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for validation_config in .
/// Nesting mode: list
/// </summary>
public class GoogleHealthcareFhirStoreValidationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Whether to disable FHIRPath validation for incoming resources. The default value is false. Set this to true to disable checking incoming resources for conformance against FHIRPath requirement defined in the FHIR specification. This property only affects resource types that do not have profiles configured for them, any rules in enabled implementation guides will still be enforced.
    /// </summary>
    public TerraformProperty<bool>? DisableFhirpathValidation
    {
        get => GetProperty<TerraformProperty<bool>>("disable_fhirpath_validation");
        set => WithProperty("disable_fhirpath_validation", value);
    }

    /// <summary>
    /// Whether to disable profile validation for this FHIR store. The default value is false. Set this to true to disable checking incoming resources for conformance against structure definitions in this FHIR store.
    /// </summary>
    public TerraformProperty<bool>? DisableProfileValidation
    {
        get => GetProperty<TerraformProperty<bool>>("disable_profile_validation");
        set => WithProperty("disable_profile_validation", value);
    }

    /// <summary>
    /// Whether to disable reference type validation for incoming resources. The default value is false. Set this to true to disable checking incoming resources for conformance against reference type requirement defined in the FHIR specification. This property only affects resource types that do not have profiles configured for them, any rules in enabled implementation guides will still be enforced.
    /// </summary>
    public TerraformProperty<bool>? DisableReferenceTypeValidation
    {
        get => GetProperty<TerraformProperty<bool>>("disable_reference_type_validation");
        set => WithProperty("disable_reference_type_validation", value);
    }

    /// <summary>
    /// Whether to disable required fields validation for incoming resources. The default value is false. Set this to true to disable checking incoming resources for conformance against required fields requirement defined in the FHIR specification. This property only affects resource types that do not have profiles configured for them, any rules in enabled implementation guides will still be enforced.
    /// </summary>
    public TerraformProperty<bool>? DisableRequiredFieldValidation
    {
        get => GetProperty<TerraformProperty<bool>>("disable_required_field_validation");
        set => WithProperty("disable_required_field_validation", value);
    }

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
    public List<TerraformProperty<string>>? EnabledImplementationGuides
    {
        get => GetProperty<List<TerraformProperty<string>>>("enabled_implementation_guides");
        set => WithProperty("enabled_implementation_guides", value);
    }

}

/// <summary>
/// Manages a google_healthcare_fhir_store resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleHealthcareFhirStore : TerraformResource
{
    public GoogleHealthcareFhirStore(string name) : base("google_healthcare_fhir_store", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("self_link");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// Enable parsing of references within complex FHIR data types such as Extensions. If this value is set to ENABLED, then features like referential integrity and Bundle reference rewriting apply to all references. If this flag has not been specified the behavior of the FHIR store will not change, references in complex data types will not be parsed. New stores will have this value set to ENABLED by default after a notification period. Warning: turning on this flag causes processing existing resources to fail if they contain references to non-existent resources. Possible values: [&amp;quot;COMPLEX_DATA_TYPE_REFERENCE_PARSING_UNSPECIFIED&amp;quot;, &amp;quot;DISABLED&amp;quot;, &amp;quot;ENABLED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ComplexDataTypeReferenceParsing
    {
        get => GetProperty<TerraformProperty<string>>("complex_data_type_reference_parsing");
        set => this.WithProperty("complex_data_type_reference_parsing", value);
    }

    /// <summary>
    /// Identifies the dataset addressed by this request. Must be in the format
    /// &#39;projects/{project}/locations/{location}/datasets/{dataset}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    public required TerraformProperty<string> Dataset
    {
        get => GetRequiredProperty<TerraformProperty<string>>("dataset");
        set => this.WithProperty("dataset", value);
    }

    /// <summary>
    /// If true, overrides the default search behavior for this FHIR store to handling=strict which returns an error for unrecognized search parameters.
    /// If false, uses the FHIR specification default handling=lenient which ignores unrecognized search parameters.
    /// The handling can always be changed from the default on an individual API call by setting the HTTP header Prefer: handling=strict or Prefer: handling=lenient.
    /// </summary>
    public TerraformProperty<bool>? DefaultSearchHandlingStrict
    {
        get => GetProperty<TerraformProperty<bool>>("default_search_handling_strict");
        set => this.WithProperty("default_search_handling_strict", value);
    }

    /// <summary>
    /// Whether to disable referential integrity in this FHIR store. This field is immutable after FHIR store
    /// creation. The default value is false, meaning that the API will enforce referential integrity and fail the
    /// requests that will result in inconsistent state in the FHIR store. When this field is set to true, the API
    /// will skip referential integrity check. Consequently, operations that rely on references, such as
    /// Patient.get$everything, will not return all the results if broken references exist.
    /// 
    /// ** Changing this property may recreate the FHIR store (removing all data) **
    /// </summary>
    public TerraformProperty<bool>? DisableReferentialIntegrity
    {
        get => GetProperty<TerraformProperty<bool>>("disable_referential_integrity");
        set => this.WithProperty("disable_referential_integrity", value);
    }

    /// <summary>
    /// Whether to disable resource versioning for this FHIR store. This field can not be changed after the creation
    /// of FHIR store. If set to false, which is the default behavior, all write operations will cause historical
    /// versions to be recorded automatically. The historical versions can be fetched through the history APIs, but
    /// cannot be updated. If set to true, no historical versions will be kept. The server will send back errors for
    /// attempts to read the historical versions.
    /// 
    /// ** Changing this property may recreate the FHIR store (removing all data) **
    /// </summary>
    public TerraformProperty<bool>? DisableResourceVersioning
    {
        get => GetProperty<TerraformProperty<bool>>("disable_resource_versioning");
        set => this.WithProperty("disable_resource_versioning", value);
    }

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
    public TerraformProperty<bool>? EnableHistoryImport
    {
        get => GetProperty<TerraformProperty<bool>>("enable_history_import");
        set => this.WithProperty("enable_history_import", value);
    }

    /// <summary>
    /// Whether this FHIR store has the updateCreate capability. This determines if the client can use an Update
    /// operation to create a new resource with a client-specified ID. If false, all IDs are server-assigned through
    /// the Create operation and attempts to Update a non-existent resource will return errors. Please treat the audit
    /// logs with appropriate levels of care if client-specified resource IDs contain sensitive data such as patient
    /// identifiers, those IDs will be part of the FHIR resource path recorded in Cloud audit logs and Cloud Pub/Sub
    /// notifications.
    /// </summary>
    public TerraformProperty<bool>? EnableUpdateCreate
    {
        get => GetProperty<TerraformProperty<bool>>("enable_update_create");
        set => this.WithProperty("enable_update_create", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

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
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The resource name for the FhirStore.
    /// 
    /// ** Changing this property may recreate the FHIR store (removing all data) **
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The FHIR specification version. Possible values: [&amp;quot;DSTU2&amp;quot;, &amp;quot;STU3&amp;quot;, &amp;quot;R4&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetRequiredProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// Block for notification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfig block(s) allowed")]
    public List<GoogleHealthcareFhirStoreNotificationConfigBlock>? NotificationConfig
    {
        get => GetProperty<List<GoogleHealthcareFhirStoreNotificationConfigBlock>>("notification_config");
        set => this.WithProperty("notification_config", value);
    }

    /// <summary>
    /// Block for notification_configs.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleHealthcareFhirStoreNotificationConfigsBlock>? NotificationConfigs
    {
        get => GetProperty<List<GoogleHealthcareFhirStoreNotificationConfigsBlock>>("notification_configs");
        set => this.WithProperty("notification_configs", value);
    }

    /// <summary>
    /// Block for stream_configs.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleHealthcareFhirStoreStreamConfigsBlock>? StreamConfigs
    {
        get => GetProperty<List<GoogleHealthcareFhirStoreStreamConfigsBlock>>("stream_configs");
        set => this.WithProperty("stream_configs", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleHealthcareFhirStoreTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleHealthcareFhirStoreTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for validation_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ValidationConfig block(s) allowed")]
    public List<GoogleHealthcareFhirStoreValidationConfigBlock>? ValidationConfig
    {
        get => GetProperty<List<GoogleHealthcareFhirStoreValidationConfigBlock>>("validation_config");
        set => this.WithProperty("validation_config", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The fully qualified name of this dataset
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
