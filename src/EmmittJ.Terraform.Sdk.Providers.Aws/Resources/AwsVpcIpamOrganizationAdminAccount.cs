using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_ipam_organization_admin_account resource.
/// </summary>
public class AwsVpcIpamOrganizationAdminAccount : TerraformResource
{
    public AwsVpcIpamOrganizationAdminAccount(string name) : base("aws_vpc_ipam_organization_admin_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("email");
        this.DeclareOutput("name");
        this.DeclareOutput("service_principal");
    }

    /// <summary>
    /// The delegated_admin_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? DelegatedAdminAccountId
    {
        get => GetProperty<TerraformProperty<string>>("delegated_admin_account_id");
        set => this.WithProperty("delegated_admin_account_id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformExpression Email => this["email"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The service_principal attribute.
    /// </summary>
    public TerraformExpression ServicePrincipal => this["service_principal"];

}
