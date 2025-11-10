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
        SetOutput("identity_provider_arn");
        SetOutput("tags_all");
        SetOutput("identity_provider_details");
        SetOutput("identity_provider_name");
        SetOutput("identity_provider_type");
        SetOutput("portal_arn");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The identity_provider_details attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityProviderDetails is required")]
    public Dictionary<string, TerraformProperty<string>> IdentityProviderDetails
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("identity_provider_details");
        set => SetProperty("identity_provider_details", value);
    }

    /// <summary>
    /// The identity_provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityProviderName is required")]
    public required TerraformProperty<string> IdentityProviderName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_provider_name");
        set => SetProperty("identity_provider_name", value);
    }

    /// <summary>
    /// The identity_provider_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityProviderType is required")]
    public required TerraformProperty<string> IdentityProviderType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_provider_type");
        set => SetProperty("identity_provider_type", value);
    }

    /// <summary>
    /// The portal_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortalArn is required")]
    public required TerraformProperty<string> PortalArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("portal_arn");
        set => SetProperty("portal_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
