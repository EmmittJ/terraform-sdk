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
    public TerraformLiteralProperty<Dictionary<string, string>>? IdentityProviderDetails
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("identity_provider_details");
        set => this.WithProperty("identity_provider_details", value);
    }

    /// <summary>
    /// The identity_provider_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IdentityProviderName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_provider_name");
        set => this.WithProperty("identity_provider_name", value);
    }

    /// <summary>
    /// The identity_provider_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IdentityProviderType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_provider_type");
        set => this.WithProperty("identity_provider_type", value);
    }

    /// <summary>
    /// The portal_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PortalArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("portal_arn");
        set => this.WithProperty("portal_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
