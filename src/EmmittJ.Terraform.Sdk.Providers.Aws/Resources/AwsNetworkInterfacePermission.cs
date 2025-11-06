using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_network_interface_permission resource.
/// </summary>
public class AwsNetworkInterfacePermission : TerraformResource
{
    public AwsNetworkInterfacePermission(string name) : base("aws_network_interface_permission", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("network_interface_permission_id");
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public string? AwsAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aws_account_id")?.Value;
        set => this.WithProperty("aws_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public string? NetworkInterfaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_interface_id")?.Value;
        set => this.WithProperty("network_interface_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The permission attribute.
    /// </summary>
    public string? Permission
    {
        get => GetProperty<TerraformLiteralProperty<string>>("permission")?.Value;
        set => this.WithProperty("permission", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The network_interface_permission_id attribute.
    /// </summary>
    public TerraformExpression NetworkInterfacePermissionId => this["network_interface_permission_id"];

}
