using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_inspector2_organization_configuration resource.
/// </summary>
public class AwsInspector2OrganizationConfiguration : TerraformResource
{
    public AwsInspector2OrganizationConfiguration(string name) : base("aws_inspector2_organization_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("max_account_limit_reached");
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
    /// The max_account_limit_reached attribute.
    /// </summary>
    public TerraformExpression MaxAccountLimitReached => this["max_account_limit_reached"];

}
