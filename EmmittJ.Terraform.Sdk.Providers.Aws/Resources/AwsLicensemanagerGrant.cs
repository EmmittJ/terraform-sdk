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
        this.DeclareOutput("arn");
        this.DeclareOutput("home_region");
        this.DeclareOutput("parent_arn");
        this.DeclareOutput("status");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// Allowed operations for the grant. This is a subset of the allowed operations on the license.
    /// </summary>
    public HashSet<string>? AllowedOperations
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("allowed_operations")?.Value;
        set => this.WithProperty("allowed_operations", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// License ARN.
    /// </summary>
    public string? LicenseArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_arn")?.Value;
        set => this.WithProperty("license_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Name of the grant.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The grantee principal ARN. The target account for the grant in the form of the ARN for an account principal of the root user.
    /// </summary>
    public string? Principal
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal")?.Value;
        set => this.WithProperty("principal", value == null ? null : new TerraformLiteralProperty<string>(value));
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
