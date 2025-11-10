using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_parameter_manager_parameter.
/// </summary>
public class GoogleParameterManagerParameterDataSource : TerraformDataSource
{
    public GoogleParameterManagerParameterDataSource(string name) : base("google_parameter_manager_parameter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("format");
        SetOutput("kms_key");
        SetOutput("labels");
        SetOutput("name");
        SetOutput("policy_member");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("id");
        SetOutput("parameter_id");
        SetOutput("project");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// This must be unique within the project.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterId is required")]
    public required TerraformProperty<string> ParameterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parameter_id");
        set => SetProperty("parameter_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The time at which the Parameter was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The format type of the parameter resource. Default value: &amp;quot;UNFORMATTED&amp;quot; Possible values: [&amp;quot;UNFORMATTED&amp;quot;, &amp;quot;YAML&amp;quot;, &amp;quot;JSON&amp;quot;]
    /// </summary>
    public TerraformExpression Format => this["format"];

    /// <summary>
    /// The resource name of the Cloud KMS CryptoKey used to encrypt parameter version payload. Format
    /// &#39;projects/{{project}}/locations/global/keyRings/{{key_ring}}/cryptoKeys/{{crypto_key}}&#39;
    /// </summary>
    public TerraformExpression KmsKey => this["kms_key"];

    /// <summary>
    /// The labels assigned to this Parameter.
    /// 
    /// Label keys must be between 1 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes,
    /// and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62}
    /// 
    /// Label values must be between 0 and 63 characters long, have a UTF-8 encoding of maximum 128 bytes,
    /// and must conform to the following PCRE regular expression: [\p{Ll}\p{Lo}\p{N}_-]{0,63}
    /// 
    /// No more than 64 labels can be assigned to a given resource.
    /// 
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example:
    /// { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// The resource name of the Parameter. Format:
    /// &#39;projects/{{project}}/locations/global/parameters/{{parameter_id}}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Policy member strings of a Google Cloud resource.
    /// </summary>
    public TerraformExpression PolicyMember => this["policy_member"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// The time at which the Parameter was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
