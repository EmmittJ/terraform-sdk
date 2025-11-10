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
        this.WithOutput("allowed_operations");
        this.WithOutput("home_region");
        this.WithOutput("license_arn");
        this.WithOutput("name");
        this.WithOutput("parent_arn");
        this.WithOutput("principal");
        this.WithOutput("status");
        this.WithOutput("version");
    }

    /// <summary>
    /// Amazon Resource Name (ARN) of the grant.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrantArn is required")]
    public required TerraformProperty<string> GrantArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("grant_arn");
        set => this.WithProperty("grant_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
