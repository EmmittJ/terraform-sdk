using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_organizations_delegated_administrator resource.
/// </summary>
public class AwsOrganizationsDelegatedAdministrator : TerraformResource
{
    public AwsOrganizationsDelegatedAdministrator(string name) : base("aws_organizations_delegated_administrator", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("delegation_enabled_date");
        SetOutput("email");
        SetOutput("joined_method");
        SetOutput("joined_timestamp");
        SetOutput("name");
        SetOutput("status");
        SetOutput("account_id");
        SetOutput("id");
        SetOutput("service_principal");
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
    /// The service_principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipal is required")]
    public required TerraformProperty<string> ServicePrincipal
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_principal");
        set => SetProperty("service_principal", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The delegation_enabled_date attribute.
    /// </summary>
    public TerraformExpression DelegationEnabledDate => this["delegation_enabled_date"];

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformExpression Email => this["email"];

    /// <summary>
    /// The joined_method attribute.
    /// </summary>
    public TerraformExpression JoinedMethod => this["joined_method"];

    /// <summary>
    /// The joined_timestamp attribute.
    /// </summary>
    public TerraformExpression JoinedTimestamp => this["joined_timestamp"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
