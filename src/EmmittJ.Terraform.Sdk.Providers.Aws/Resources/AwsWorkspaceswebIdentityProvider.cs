using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_workspacesweb_identity_provider resource.
/// </summary>
public class AwsWorkspaceswebIdentityProvider : TerraformResource
{
    public AwsWorkspaceswebIdentityProvider(string name) : base("aws_workspacesweb_identity_provider", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("identity_provider_arn");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The identity_provider_details attribute.
    /// </summary>
    public Dictionary<string, string>? IdentityProviderDetails
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("identity_provider_details")?.Value;
        set => this.WithProperty("identity_provider_details", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The identity_provider_name attribute.
    /// </summary>
    public string? IdentityProviderName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_provider_name")?.Value;
        set => this.WithProperty("identity_provider_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The identity_provider_type attribute.
    /// </summary>
    public string? IdentityProviderType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_provider_type")?.Value;
        set => this.WithProperty("identity_provider_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The portal_arn attribute.
    /// </summary>
    public string? PortalArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("portal_arn")?.Value;
        set => this.WithProperty("portal_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The identity_provider_arn attribute.
    /// </summary>
    public TerraformExpression IdentityProviderArn => this["identity_provider_arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
