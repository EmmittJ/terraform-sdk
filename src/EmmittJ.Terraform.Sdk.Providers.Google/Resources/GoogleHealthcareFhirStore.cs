using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_healthcare_fhir_store resource.
/// </summary>
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
    public TerraformProperty<string>? Dataset
    {
        get => GetProperty<TerraformProperty<string>>("dataset");
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
    public TerraformMapProperty<string>? Labels
    {
        get => GetProperty<TerraformMapProperty<string>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The resource name for the FhirStore.
    /// 
    /// ** Changing this property may recreate the FHIR store (removing all data) **
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The FHIR specification version. Possible values: [&amp;quot;DSTU2&amp;quot;, &amp;quot;STU3&amp;quot;, &amp;quot;R4&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
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
