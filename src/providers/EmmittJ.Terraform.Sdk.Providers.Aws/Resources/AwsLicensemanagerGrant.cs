using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_licensemanager_grant Terraform resource.
/// Manages a aws_licensemanager_grant resource.
/// </summary>
public partial class AwsLicensemanagerGrant(string name) : TerraformResource("aws_licensemanager_grant", name)
{
    /// <summary>
    /// Allowed operations for the grant. This is a subset of the allowed operations on the license.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOperations is required")]
    public required TerraformSet<string> AllowedOperations
    {
        get => GetRequiredArgument<TerraformSet<string>>("allowed_operations");
        set => SetArgument("allowed_operations", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// License ARN.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseArn is required")]
    public required TerraformValue<string> LicenseArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("license_arn");
        set => SetArgument("license_arn", value);
    }

    /// <summary>
    /// Name of the grant.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The grantee principal ARN. The target account for the grant in the form of the ARN for an account principal of the root user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformValue<string> Principal
    {
        get => GetRequiredArgument<TerraformValue<string>>("principal");
        set => SetArgument("principal", value);
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
    /// Amazon Resource Name (ARN) of the grant.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// Home Region of the grant.
    /// </summary>
    public TerraformValue<string> HomeRegion
        => AsReference("home_region");

    /// <summary>
    /// Parent ARN.
    /// </summary>
    public TerraformValue<string> ParentArn
        => AsReference("parent_arn");

    /// <summary>
    /// Grant status.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// Grant version.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

}
