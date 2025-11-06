using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_organizations_delegated_administrators.
/// </summary>
public class AwsOrganizationsDelegatedAdministratorsDataSource : TerraformDataSource
{
    public AwsOrganizationsDelegatedAdministratorsDataSource(string name) : base("aws_organizations_delegated_administrators", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("delegated_administrators");
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
    /// The service_principal attribute.
    /// </summary>
    public string? ServicePrincipal
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_principal")?.Value;
        set => this.WithProperty("service_principal", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The delegated_administrators attribute.
    /// </summary>
    public TerraformExpression DelegatedAdministrators => this["delegated_administrators"];

}
