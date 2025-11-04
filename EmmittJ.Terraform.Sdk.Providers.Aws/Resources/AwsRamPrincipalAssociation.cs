using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ram_principal_association resource.
/// </summary>
public class AwsRamPrincipalAssociation : TerraformResource
{
    public AwsRamPrincipalAssociation(string name) : base("aws_ram_principal_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The principal attribute.
    /// </summary>
    public string? Principal
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal")?.Value;
        set => this.WithProperty("principal", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_share_arn attribute.
    /// </summary>
    public string? ResourceShareArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_share_arn")?.Value;
        set => this.WithProperty("resource_share_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
