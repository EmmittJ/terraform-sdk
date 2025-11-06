using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_globalaccelerator_listener resource.
/// </summary>
public class AwsGlobalacceleratorListener : TerraformResource
{
    public AwsGlobalacceleratorListener(string name) : base("aws_globalaccelerator_listener", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The accelerator_arn attribute.
    /// </summary>
    public string? AcceleratorArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("accelerator_arn")?.Value;
        set => this.WithProperty("accelerator_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The client_affinity attribute.
    /// </summary>
    public string? ClientAffinity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_affinity")?.Value;
        set => this.WithProperty("client_affinity", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The protocol attribute.
    /// </summary>
    public string? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol")?.Value;
        set => this.WithProperty("protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
