using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_organizations_delegated_services.
/// </summary>
public class AwsOrganizationsDelegatedServicesDataSource : TerraformDataSource
{
    public AwsOrganizationsDelegatedServicesDataSource(string name) : base("aws_organizations_delegated_services", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("delegated_services");
        SetOutput("account_id");
        SetOutput("id");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    public required TerraformProperty<string> AccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_id");
        set => SetProperty("account_id", value);
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
    /// The delegated_services attribute.
    /// </summary>
    public TerraformExpression DelegatedServices => this["delegated_services"];

}
