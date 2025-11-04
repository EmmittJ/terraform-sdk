using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sesv2_email_identity resource.
/// </summary>
public class AwsSesv2EmailIdentity : TerraformResource
{
    public AwsSesv2EmailIdentity(string name) : base("aws_sesv2_email_identity", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("identity_type");
        this.DeclareOutput("verified_for_sending_status");
    }

    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    public string? ConfigurationSetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configuration_set_name")?.Value;
        set => this.WithProperty("configuration_set_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The email_identity attribute.
    /// </summary>
    public string? EmailIdentity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_identity")?.Value;
        set => this.WithProperty("email_identity", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The identity_type attribute.
    /// </summary>
    public TerraformExpression IdentityType => this["identity_type"];

    /// <summary>
    /// The verified_for_sending_status attribute.
    /// </summary>
    public TerraformExpression VerifiedForSendingStatus => this["verified_for_sending_status"];

}
