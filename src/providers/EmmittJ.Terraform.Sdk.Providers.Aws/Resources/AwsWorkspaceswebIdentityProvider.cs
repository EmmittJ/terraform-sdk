using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_workspacesweb_identity_provider Terraform resource.
/// Manages a aws_workspacesweb_identity_provider resource.
/// </summary>
public partial class AwsWorkspaceswebIdentityProvider(string name) : TerraformResource("aws_workspacesweb_identity_provider", name)
{
    /// <summary>
    /// The identity_provider_details attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityProviderDetails is required")]
    public required TerraformMap<string> IdentityProviderDetails
    {
        get => GetRequiredArgument<TerraformMap<string>>("identity_provider_details");
        set => SetArgument("identity_provider_details", value);
    }

    /// <summary>
    /// The identity_provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityProviderName is required")]
    public required TerraformValue<string> IdentityProviderName
    {
        get => GetRequiredArgument<TerraformValue<string>>("identity_provider_name");
        set => SetArgument("identity_provider_name", value);
    }

    /// <summary>
    /// The identity_provider_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityProviderType is required")]
    public required TerraformValue<string> IdentityProviderType
    {
        get => GetRequiredArgument<TerraformValue<string>>("identity_provider_type");
        set => SetArgument("identity_provider_type", value);
    }

    /// <summary>
    /// The portal_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortalArn is required")]
    public required TerraformValue<string> PortalArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("portal_arn");
        set => SetArgument("portal_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The identity_provider_arn attribute.
    /// </summary>
    public TerraformValue<string> IdentityProviderArn
        => AsReference("identity_provider_arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

}
