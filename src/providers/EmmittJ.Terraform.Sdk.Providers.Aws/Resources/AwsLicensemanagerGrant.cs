using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_licensemanager_grant resource.
/// </summary>
public class AwsLicensemanagerGrant : TerraformResource
{
    public AwsLicensemanagerGrant(string name) : base("aws_licensemanager_grant", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("home_region");
        SetOutput("parent_arn");
        SetOutput("status");
        SetOutput("version");
        SetOutput("allowed_operations");
        SetOutput("id");
        SetOutput("license_arn");
        SetOutput("name");
        SetOutput("principal");
        SetOutput("region");
    }

    /// <summary>
    /// Allowed operations for the grant. This is a subset of the allowed operations on the license.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOperations is required")]
    public HashSet<TerraformProperty<string>> AllowedOperations
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("allowed_operations");
        set => SetProperty("allowed_operations", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// License ARN.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseArn is required")]
    public required TerraformProperty<string> LicenseArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("license_arn");
        set => SetProperty("license_arn", value);
    }

    /// <summary>
    /// Name of the grant.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The grantee principal ARN. The target account for the grant in the form of the ARN for an account principal of the root user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformProperty<string> Principal
    {
        get => GetRequiredOutput<TerraformProperty<string>>("principal");
        set => SetProperty("principal", value);
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
    /// Amazon Resource Name (ARN) of the grant.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// Home Region of the grant.
    /// </summary>
    public TerraformExpression HomeRegion => this["home_region"];

    /// <summary>
    /// Parent ARN.
    /// </summary>
    public TerraformExpression ParentArn => this["parent_arn"];

    /// <summary>
    /// Grant status.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// Grant version.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
