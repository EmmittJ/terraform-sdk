using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_lakeformation_resource Terraform resource.
/// Manages a aws_lakeformation_resource resource.
/// </summary>
public partial class AwsLakeformationResource(string name) : TerraformResource("aws_lakeformation_resource", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The hybrid_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool> HybridAccessEnabled
    {
        get => new TerraformReference<bool>(this, "hybrid_access_enabled");
        set => SetArgument("hybrid_access_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The use_service_linked_role attribute.
    /// </summary>
    public TerraformValue<bool>? UseServiceLinkedRole
    {
        get => new TerraformReference<bool>(this, "use_service_linked_role");
        set => SetArgument("use_service_linked_role", value);
    }

    /// <summary>
    /// The with_federation attribute.
    /// </summary>
    public TerraformValue<bool> WithFederation
    {
        get => new TerraformReference<bool>(this, "with_federation");
        set => SetArgument("with_federation", value);
    }

    /// <summary>
    /// The with_privileged_access attribute.
    /// </summary>
    public TerraformValue<bool> WithPrivilegedAccess
    {
        get => new TerraformReference<bool>(this, "with_privileged_access");
        set => SetArgument("with_privileged_access", value);
    }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformValue<string> LastModified
    {
        get => new TerraformReference<string>(this, "last_modified");
    }

}
