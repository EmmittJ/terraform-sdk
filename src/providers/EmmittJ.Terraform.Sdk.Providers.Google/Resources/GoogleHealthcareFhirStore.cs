using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for notification_config in GoogleHealthcareFhirStore.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class GoogleHealthcareFhirStoreNotificationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_config";

    /// <summary>
    /// The Cloud Pub/Sub topic that notifications of changes are published on. Supplied by the client.
    /// PubsubMessage.Data will contain the resource name. PubsubMessage.MessageId is the ID of this message.
    /// It is guaranteed to be unique within the topic. PubsubMessage.PublishTime is the time at which the message
    /// was published. Notifications are only sent if the topic is non-empty. Topic names must be scoped to a
    /// project. service-PROJECT_NUMBER@gcp-sa-healthcare.iam.gserviceaccount.com must have publisher permissions on the given
    /// Cloud Pub/Sub topic. Not having adequate permissions will cause the calls that send notifications to fail.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PubsubTopic is required")]
    public required TerraformValue<string> PubsubTopic
    {
        get => new TerraformReference<string>(this, "pubsub_topic");
        set => SetArgument("pubsub_topic", value);
    }

}


/// <summary>
/// Block type for notification_configs in GoogleHealthcareFhirStore.
/// Nesting mode: list
/// </summary>
public class GoogleHealthcareFhirStoreNotificationConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_configs";

    /// <summary>
    /// The Cloud Pub/Sub topic that notifications of changes are published on. Supplied by the client.
    /// PubsubMessage.Data will contain the resource name. PubsubMessage.MessageId is the ID of this message.
    /// It is guaranteed to be unique within the topic. PubsubMessage.PublishTime is the time at which the message
    /// was published. Notifications are only sent if the topic is non-empty. Topic names must be scoped to a
    /// project. service-PROJECT_NUMBER@gcp-sa-healthcare.iam.gserviceaccount.com must have publisher permissions on the given
    /// Cloud Pub/Sub topic. Not having adequate permissions will cause the calls that send notifications to fail.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PubsubTopic is required")]
    public required TerraformValue<string> PubsubTopic
    {
        get => new TerraformReference<string>(this, "pubsub_topic");
        set => SetArgument("pubsub_topic", value);
    }

    /// <summary>
    /// Whether to send full FHIR resource to this Pub/Sub topic for Create and Update operation.
    /// Note that setting this to true does not guarantee that all resources will be sent in the format of
    /// full FHIR resource. When a resource change is too large or during heavy traffic, only the resource name will be
    /// sent. Clients should always check the &amp;quot;payloadType&amp;quot; label from a Pub/Sub message to determine whether
    /// it needs to fetch the full resource as a separate operation.
    /// </summary>
    public TerraformValue<bool>? SendFullResource
    {
        get => new TerraformReference<bool>(this, "send_full_resource");
        set => SetArgument("send_full_resource", value);
    }

    /// <summary>
    /// Whether to send full FHIR resource to this Pub/Sub topic for deleting FHIR resource. Note that setting this to
    /// true does not guarantee that all previous resources will be sent in the format of full FHIR resource. When a
    /// resource change is too large or during heavy traffic, only the resource name will be sent. Clients should always
    /// check the &amp;quot;payloadType&amp;quot; label from a Pub/Sub message to determine whether it needs to fetch the full previous
    /// resource as a separate operation.
    /// </summary>
    public TerraformValue<bool>? SendPreviousResourceOnDelete
    {
        get => new TerraformReference<bool>(this, "send_previous_resource_on_delete");
        set => SetArgument("send_previous_resource_on_delete", value);
    }

}


/// <summary>
/// Block type for stream_configs in GoogleHealthcareFhirStore.
/// Nesting mode: list
/// </summary>
public class GoogleHealthcareFhirStoreStreamConfigsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stream_configs";

    /// <summary>
    /// Supply a FHIR resource type (such as &amp;quot;Patient&amp;quot; or &amp;quot;Observation&amp;quot;). See
    /// https://www.hl7.org/fhir/valueset-resource-types.html for a list of all FHIR resource types. The server treats
    /// an empty list as an intent to stream all the supported resource types in this FHIR store.
    /// </summary>
    public TerraformList<string>? ResourceTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resource_types").ResolveNodes(ctx));
        set => SetArgument("resource_types", value);
    }

    /// <summary>
    /// BigqueryDestination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BigqueryDestination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 BigqueryDestination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigqueryDestination block(s) allowed")]
    public required TerraformList<GoogleHealthcareFhirStoreStreamConfigsBlockBigqueryDestinationBlock> BigqueryDestination
    {
        get => GetRequiredArgument<TerraformList<GoogleHealthcareFhirStoreStreamConfigsBlockBigqueryDestinationBlock>>("bigquery_destination");
        set => SetArgument("bigquery_destination", value);
    }

}

/// <summary>
/// Block type for bigquery_destination in GoogleHealthcareFhirStoreStreamConfigsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleHealthcareFhirStoreStreamConfigsBlockBigqueryDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bigquery_destination";

    /// <summary>
    /// BigQuery URI to a dataset, up to 2000 characters long, in the format bq://projectId.bqDatasetId
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetUri is required")]
    public required TerraformValue<string> DatasetUri
    {
        get => new TerraformReference<string>(this, "dataset_uri");
        set => SetArgument("dataset_uri", value);
    }

    /// <summary>
    /// SchemaConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SchemaConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaConfig block(s) allowed")]
    public required TerraformList<GoogleHealthcareFhirStoreStreamConfigsBlockBigqueryDestinationBlockSchemaConfigBlock> SchemaConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleHealthcareFhirStoreStreamConfigsBlockBigqueryDestinationBlockSchemaConfigBlock>>("schema_config");
        set => SetArgument("schema_config", value);
    }

}

/// <summary>
/// Block type for schema_config in GoogleHealthcareFhirStoreStreamConfigsBlockBigqueryDestinationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleHealthcareFhirStoreStreamConfigsBlockBigqueryDestinationBlockSchemaConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema_config";

    /// <summary>
    /// The depth for all recursive structures in the output analytics schema. For example, concept in the CodeSystem
    /// resource is a recursive structure; when the depth is 2, the CodeSystem table will have a column called
    /// concept.concept but not concept.concept.concept. If not specified or set to 0, the server will use the default
    /// value 2. The maximum depth allowed is 5.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecursiveStructureDepth is required")]
    public required TerraformValue<double> RecursiveStructureDepth
    {
        get => new TerraformReference<double>(this, "recursive_structure_depth");
        set => SetArgument("recursive_structure_depth", value);
    }

    /// <summary>
    /// Specifies the output schema type.
    ///  * ANALYTICS: Analytics schema defined by the FHIR community.
    ///   See https://github.com/FHIR/sql-on-fhir/blob/master/sql-on-fhir.md.
    ///  * ANALYTICS_V2: Analytics V2, similar to schema defined by the FHIR community, with added support for extensions with one or more occurrences and contained resources in stringified JSON.
    ///  * LOSSLESS: A data-driven schema generated from the fields present in the FHIR data being exported, with no additional simplification. Default value: &amp;quot;ANALYTICS&amp;quot; Possible values: [&amp;quot;ANALYTICS&amp;quot;, &amp;quot;ANALYTICS_V2&amp;quot;, &amp;quot;LOSSLESS&amp;quot;]
    /// </summary>
    public TerraformValue<string>? SchemaType
    {
        get => new TerraformReference<string>(this, "schema_type");
        set => SetArgument("schema_type", value);
    }

    /// <summary>
    /// LastUpdatedPartitionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LastUpdatedPartitionConfig block(s) allowed")]
    public TerraformList<GoogleHealthcareFhirStoreStreamConfigsBlockBigqueryDestinationBlockSchemaConfigBlockLastUpdatedPartitionConfigBlock>? LastUpdatedPartitionConfig
    {
        get => GetArgument<TerraformList<GoogleHealthcareFhirStoreStreamConfigsBlockBigqueryDestinationBlockSchemaConfigBlockLastUpdatedPartitionConfigBlock>>("last_updated_partition_config");
        set => SetArgument("last_updated_partition_config", value);
    }

}

/// <summary>
/// Block type for last_updated_partition_config in GoogleHealthcareFhirStoreStreamConfigsBlockBigqueryDestinationBlockSchemaConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleHealthcareFhirStoreStreamConfigsBlockBigqueryDestinationBlockSchemaConfigBlockLastUpdatedPartitionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "last_updated_partition_config";

    /// <summary>
    /// Number of milliseconds for which to keep the storage for a partition.
    /// </summary>
    public TerraformValue<string>? ExpirationMs
    {
        get => new TerraformReference<string>(this, "expiration_ms");
        set => SetArgument("expiration_ms", value);
    }

    /// <summary>
    /// Type of partitioning. Possible values: [&amp;quot;PARTITION_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;HOUR&amp;quot;, &amp;quot;DAY&amp;quot;, &amp;quot;MONTH&amp;quot;, &amp;quot;YEAR&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleHealthcareFhirStore.
/// Nesting mode: single
/// </summary>
public class GoogleHealthcareFhirStoreTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for validation_config in GoogleHealthcareFhirStore.
/// Nesting mode: list
/// </summary>
public class GoogleHealthcareFhirStoreValidationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "validation_config";

    /// <summary>
    /// Whether to disable FHIRPath validation for incoming resources. The default value is false. Set this to true to disable checking incoming resources for conformance against FHIRPath requirement defined in the FHIR specification. This property only affects resource types that do not have profiles configured for them, any rules in enabled implementation guides will still be enforced.
    /// </summary>
    public TerraformValue<bool>? DisableFhirpathValidation
    {
        get => new TerraformReference<bool>(this, "disable_fhirpath_validation");
        set => SetArgument("disable_fhirpath_validation", value);
    }

    /// <summary>
    /// Whether to disable profile validation for this FHIR store. The default value is false. Set this to true to disable checking incoming resources for conformance against structure definitions in this FHIR store.
    /// </summary>
    public TerraformValue<bool>? DisableProfileValidation
    {
        get => new TerraformReference<bool>(this, "disable_profile_validation");
        set => SetArgument("disable_profile_validation", value);
    }

    /// <summary>
    /// Whether to disable reference type validation for incoming resources. The default value is false. Set this to true to disable checking incoming resources for conformance against reference type requirement defined in the FHIR specification. This property only affects resource types that do not have profiles configured for them, any rules in enabled implementation guides will still be enforced.
    /// </summary>
    public TerraformValue<bool>? DisableReferenceTypeValidation
    {
        get => new TerraformReference<bool>(this, "disable_reference_type_validation");
        set => SetArgument("disable_reference_type_validation", value);
    }

    /// <summary>
    /// Whether to disable required fields validation for incoming resources. The default value is false. Set this to true to disable checking incoming resources for conformance against required fields requirement defined in the FHIR specification. This property only affects resource types that do not have profiles configured for them, any rules in enabled implementation guides will still be enforced.
    /// </summary>
    public TerraformValue<bool>? DisableRequiredFieldValidation
    {
        get => new TerraformReference<bool>(this, "disable_required_field_validation");
        set => SetArgument("disable_required_field_validation", value);
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
    public TerraformList<string>? EnabledImplementationGuides
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "enabled_implementation_guides").ResolveNodes(ctx));
        set => SetArgument("enabled_implementation_guides", value);
    }

}


/// <summary>
/// Represents a google_healthcare_fhir_store Terraform resource.
/// Manages a google_healthcare_fhir_store resource.
/// </summary>
public partial class GoogleHealthcareFhirStore(string name) : TerraformResource("google_healthcare_fhir_store", name)
{
    /// <summary>
    /// Enable parsing of references within complex FHIR data types such as Extensions. If this value is set to ENABLED, then features like referential integrity and Bundle reference rewriting apply to all references. If this flag has not been specified the behavior of the FHIR store will not change, references in complex data types will not be parsed. New stores will have this value set to ENABLED by default after a notification period. Warning: turning on this flag causes processing existing resources to fail if they contain references to non-existent resources. Possible values: [&amp;quot;COMPLEX_DATA_TYPE_REFERENCE_PARSING_UNSPECIFIED&amp;quot;, &amp;quot;DISABLED&amp;quot;, &amp;quot;ENABLED&amp;quot;]
    /// </summary>
    public TerraformValue<string> ComplexDataTypeReferenceParsing
    {
        get => new TerraformReference<string>(this, "complex_data_type_reference_parsing");
        set => SetArgument("complex_data_type_reference_parsing", value);
    }

    /// <summary>
    /// Identifies the dataset addressed by this request. Must be in the format
    /// &#39;projects/{project}/locations/{location}/datasets/{dataset}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    public required TerraformValue<string> Dataset
    {
        get => new TerraformReference<string>(this, "dataset");
        set => SetArgument("dataset", value);
    }

    /// <summary>
    /// If true, overrides the default search behavior for this FHIR store to handling=strict which returns an error for unrecognized search parameters.
    /// If false, uses the FHIR specification default handling=lenient which ignores unrecognized search parameters.
    /// The handling can always be changed from the default on an individual API call by setting the HTTP header Prefer: handling=strict or Prefer: handling=lenient.
    /// </summary>
    public TerraformValue<bool>? DefaultSearchHandlingStrict
    {
        get => new TerraformReference<bool>(this, "default_search_handling_strict");
        set => SetArgument("default_search_handling_strict", value);
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
    public TerraformValue<bool>? DisableReferentialIntegrity
    {
        get => new TerraformReference<bool>(this, "disable_referential_integrity");
        set => SetArgument("disable_referential_integrity", value);
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
    public TerraformValue<bool>? DisableResourceVersioning
    {
        get => new TerraformReference<bool>(this, "disable_resource_versioning");
        set => SetArgument("disable_resource_versioning", value);
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
    public TerraformValue<bool>? EnableHistoryImport
    {
        get => new TerraformReference<bool>(this, "enable_history_import");
        set => SetArgument("enable_history_import", value);
    }

    /// <summary>
    /// Whether this FHIR store has the updateCreate capability. This determines if the client can use an Update
    /// operation to create a new resource with a client-specified ID. If false, all IDs are server-assigned through
    /// the Create operation and attempts to Update a non-existent resource will return errors. Please treat the audit
    /// logs with appropriate levels of care if client-specified resource IDs contain sensitive data such as patient
    /// identifiers, those IDs will be part of the FHIR resource path recorded in Cloud audit logs and Cloud Pub/Sub
    /// notifications.
    /// </summary>
    public TerraformValue<bool>? EnableUpdateCreate
    {
        get => new TerraformReference<bool>(this, "enable_update_create");
        set => SetArgument("enable_update_create", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The resource name for the FhirStore.
    /// 
    /// ** Changing this property may recreate the FHIR store (removing all data) **
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The FHIR specification version. Possible values: [&amp;quot;DSTU2&amp;quot;, &amp;quot;STU3&amp;quot;, &amp;quot;R4&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The fully qualified name of this dataset
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// NotificationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfig block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public TerraformList<GoogleHealthcareFhirStoreNotificationConfigBlock>? NotificationConfig
    {
        get => GetArgument<TerraformList<GoogleHealthcareFhirStoreNotificationConfigBlock>>("notification_config");
        set => SetArgument("notification_config", value);
    }

    /// <summary>
    /// NotificationConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleHealthcareFhirStoreNotificationConfigsBlock>? NotificationConfigs
    {
        get => GetArgument<TerraformList<GoogleHealthcareFhirStoreNotificationConfigsBlock>>("notification_configs");
        set => SetArgument("notification_configs", value);
    }

    /// <summary>
    /// StreamConfigs block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleHealthcareFhirStoreStreamConfigsBlock>? StreamConfigs
    {
        get => GetArgument<TerraformList<GoogleHealthcareFhirStoreStreamConfigsBlock>>("stream_configs");
        set => SetArgument("stream_configs", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleHealthcareFhirStoreTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleHealthcareFhirStoreTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// ValidationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ValidationConfig block(s) allowed")]
    public TerraformList<GoogleHealthcareFhirStoreValidationConfigBlock>? ValidationConfig
    {
        get => GetArgument<TerraformList<GoogleHealthcareFhirStoreValidationConfigBlock>>("validation_config");
        set => SetArgument("validation_config", value);
    }

}
