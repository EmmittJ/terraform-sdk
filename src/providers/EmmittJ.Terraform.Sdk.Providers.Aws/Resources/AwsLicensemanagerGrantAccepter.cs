using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_licensemanager_grant_accepter resource.
/// </summary>
public class AwsLicensemanagerGrantAccepter : TerraformResource
{
    public AwsLicensemanagerGrantAccepter(string name) : base("aws_licensemanager_grant_accepter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("allowed_operations");
        SetOutput("home_region");
        SetOutput("license_arn");
        SetOutput("name");
        SetOutput("parent_arn");
        SetOutput("principal");
        SetOutput("status");
        SetOutput("version");
        SetOutput("grant_arn");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// Amazon Resource Name (ARN) of the grant.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrantArn is required")]
    public required TerraformProperty<string> GrantArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("grant_arn");
        set => SetProperty("grant_arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Allowed operations for the grant.
    /// </summary>
    public TerraformExpression AllowedOperations => this["allowed_operations"];

    /// <summary>
    /// Home Region of the grant.
    /// </summary>
    public TerraformExpression HomeRegion => this["home_region"];

    /// <summary>
    /// License ARN.
    /// </summary>
    public TerraformExpression LicenseArn => this["license_arn"];

    /// <summary>
    /// Name of the grant.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Parent ARN.
    /// </summary>
    public TerraformExpression ParentArn => this["parent_arn"];

    /// <summary>
    /// The grantee principal ARN.
    /// </summary>
    public TerraformExpression Principal => this["principal"];

    /// <summary>
    /// GrantAccepter status.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// GrantAccepter version.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
