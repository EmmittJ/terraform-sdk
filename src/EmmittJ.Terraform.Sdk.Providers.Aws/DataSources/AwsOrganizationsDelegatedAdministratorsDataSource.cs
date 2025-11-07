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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The service_principal attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServicePrincipal
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_principal");
        set => this.WithProperty("service_principal", value);
    }

    /// <summary>
    /// The delegated_administrators attribute.
    /// </summary>
    public TerraformExpression DelegatedAdministrators => this["delegated_administrators"];

}
