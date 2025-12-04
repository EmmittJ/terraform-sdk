using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleHealthcareConsentStore.
/// Nesting mode: single
/// </summary>
public class GoogleHealthcareConsentStoreTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_healthcare_consent_store Terraform resource.
/// Manages a google_healthcare_consent_store resource.
/// </summary>
public partial class GoogleHealthcareConsentStore(string name) : TerraformResource("google_healthcare_consent_store", name)
{
    /// <summary>
    /// Identifies the dataset addressed by this request. Must be in the format
    /// &#39;projects/{project}/locations/{location}/datasets/{dataset}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    public required TerraformValue<string> Dataset
    {
        get => GetArgument<TerraformValue<string>>("dataset");
        set => SetArgument("dataset", value);
    }

    /// <summary>
    /// Default time to live for consents in this store. Must be at least 24 hours. Updating this field will not affect the expiration time of existing consents.
    /// 
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformValue<string>? DefaultConsentTtl
    {
        get => GetArgument<TerraformValue<string>>("default_consent_ttl");
        set => SetArgument("default_consent_ttl", value);
    }

    /// <summary>
    /// If true, [consents.patch] [google.cloud.healthcare.v1.consent.UpdateConsent] creates the consent if it does not already exist.
    /// </summary>
    public TerraformValue<bool>? EnableConsentCreateOnUpdate
    {
        get => GetArgument<TerraformValue<bool>>("enable_consent_create_on_update");
        set => SetArgument("enable_consent_create_on_update", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// User-supplied key-value pairs used to organize Consent stores.
    /// 
    /// Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes, and must
    /// conform to the following PCRE regular expression: &#39;[\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62}&#39;
    /// 
    /// Label values are optional, must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128
    /// bytes, and must conform to the following PCRE regular expression: &#39;[\p{Ll}\p{Lo}\p{N}_-]{0,63}&#39;
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
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The name of this ConsentStore, for example:
    /// &amp;quot;consent1&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleHealthcareConsentStoreTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleHealthcareConsentStoreTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
