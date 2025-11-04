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
        this.DeclareOutput("allowed_operations");
        this.DeclareOutput("home_region");
        this.DeclareOutput("license_arn");
        this.DeclareOutput("name");
        this.DeclareOutput("parent_arn");
        this.DeclareOutput("principal");
        this.DeclareOutput("status");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// Amazon Resource Name (ARN) of the grant.
    /// </summary>
    public string? GrantArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("grant_arn")?.Value;
        set => this.WithProperty("grant_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
