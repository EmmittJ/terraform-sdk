using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_parameter_manager_parameter resource.
/// </summary>
public class GoogleParameterManagerParameter : TerraformResource
{
    public GoogleParameterManagerParameter(string name) : base("google_parameter_manager_parameter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("name");
        this.DeclareOutput("policy_member");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The format type of the parameter resource. Default value: &amp;quot;UNFORMATTED&amp;quot; Possible values: [&amp;quot;UNFORMATTED&amp;quot;, &amp;quot;YAML&amp;quot;, &amp;quot;JSON&amp;quot;]
    /// </summary>
    public string? Format
    {
        get => GetProperty<TerraformLiteralProperty<string>>("format")?.Value;
        set => this.WithProperty("format", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource name of the Cloud KMS CryptoKey used to encrypt parameter version payload. Format
    /// &#39;projects/{{project}}/locations/global/keyRings/{{key_ring}}/cryptoKeys/{{crypto_key}}&#39;
    /// </summary>
    public string? KmsKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key")?.Value;
        set => this.WithProperty("kms_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

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
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// This must be unique within the project.
    /// </summary>
    public string? ParameterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parameter_id")?.Value;
        set => this.WithProperty("parameter_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
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
