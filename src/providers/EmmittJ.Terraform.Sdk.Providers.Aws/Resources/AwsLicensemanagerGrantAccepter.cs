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
        get => new TerraformReference<string>(this, "grant_arn");
        set => SetArgument("grant_arn", value);
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
    /// Allowed operations for the grant.
    /// </summary>
    public TerraformSet<string> AllowedOperations
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_operations").ResolveNodes(ctx));
    }

    /// <summary>
    /// Home Region of the grant.
    /// </summary>
    public TerraformValue<string> HomeRegion
    {
        get => new TerraformReference<string>(this, "home_region");
    }

    /// <summary>
    /// License ARN.
    /// </summary>
    public TerraformValue<string> LicenseArn
    {
        get => new TerraformReference<string>(this, "license_arn");
    }

    /// <summary>
    /// Name of the grant.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Parent ARN.
    /// </summary>
    public TerraformValue<string> ParentArn
    {
        get => new TerraformReference<string>(this, "parent_arn");
    }

    /// <summary>
    /// The grantee principal ARN.
    /// </summary>
    public TerraformValue<string> Principal
    {
        get => new TerraformReference<string>(this, "principal");
    }

    /// <summary>
    /// GrantAccepter status.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// GrantAccepter version.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

}
