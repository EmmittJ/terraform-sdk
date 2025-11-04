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
        this.DeclareOutput("arn");
        this.DeclareOutput("delegation_enabled_date");
        this.DeclareOutput("email");
        this.DeclareOutput("joined_method");
        this.DeclareOutput("joined_timestamp");
        this.DeclareOutput("name");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public string? AccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_id")?.Value;
        set => this.WithProperty("account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
