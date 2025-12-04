using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_licensemanager_grant_accepter Terraform resource.
/// Manages a aws_licensemanager_grant_accepter resource.
/// </summary>
public partial class AwsLicensemanagerGrantAccepter(string name) : TerraformResource("aws_licensemanager_grant_accepter", name)
{
    /// <summary>
    /// Amazon Resource Name (ARN) of the grant.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrantArn is required")]
    public required TerraformValue<string> GrantArn
    {
        get => GetArgument<TerraformValue<string>>("grant_arn");
        set => SetArgument("grant_arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Allowed operations for the grant.
    /// </summary>
    public TerraformSet<string> AllowedOperations
        => AsReference("allowed_operations");

    /// <summary>
    /// Home Region of the grant.
    /// </summary>
    public TerraformValue<string> HomeRegion
        => AsReference("home_region");

    /// <summary>
    /// License ARN.
    /// </summary>
    public TerraformValue<string> LicenseArn
        => AsReference("license_arn");

    /// <summary>
    /// Name of the grant.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Parent ARN.
    /// </summary>
    public TerraformValue<string> ParentArn
        => AsReference("parent_arn");

    /// <summary>
    /// The grantee principal ARN.
    /// </summary>
    public TerraformValue<string> Principal
        => AsReference("principal");

    /// <summary>
    /// GrantAccepter status.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// GrantAccepter version.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

}
