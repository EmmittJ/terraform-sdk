using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_workspacesweb_trust_store_association Terraform resource.
/// Manages a aws_workspacesweb_trust_store_association resource.
/// </summary>
public partial class AwsWorkspaceswebTrustStoreAssociation(string name) : TerraformResource("aws_workspacesweb_trust_store_association", name)
{
    /// <summary>
    /// The portal_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortalArn is required")]
    public required TerraformValue<string> PortalArn
    {
        get => GetArgument<TerraformValue<string>>("portal_arn");
        set => SetArgument("portal_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustStoreArn is required")]
    public required TerraformValue<string> TrustStoreArn
    {
        get => GetArgument<TerraformValue<string>>("trust_store_arn");
        set => SetArgument("trust_store_arn", value);
    }

}
