using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dx_router_configuration.
/// </summary>
public class AwsDxRouterConfigurationDataSource : TerraformDataSource
{
    public AwsDxRouterConfigurationDataSource(string name) : base("aws_dx_router_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("customer_router_config");
        this.DeclareOutput("router");
        this.DeclareOutput("virtual_interface_name");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The router_type_identifier attribute.
    /// </summary>
    public string? RouterTypeIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("router_type_identifier")?.Value;
        set => this.WithProperty("router_type_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The virtual_interface_id attribute.
    /// </summary>
    public string? VirtualInterfaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_interface_id")?.Value;
        set => this.WithProperty("virtual_interface_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The customer_router_config attribute.
    /// </summary>
    public TerraformExpression CustomerRouterConfig => this["customer_router_config"];

    /// <summary>
    /// The router attribute.
    /// </summary>
    public TerraformExpression Router => this["router"];

    /// <summary>
    /// The virtual_interface_name attribute.
    /// </summary>
    public TerraformExpression VirtualInterfaceName => this["virtual_interface_name"];

}
