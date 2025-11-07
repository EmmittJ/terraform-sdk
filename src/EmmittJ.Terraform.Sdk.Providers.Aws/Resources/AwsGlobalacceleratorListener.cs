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
    public TerraformLiteralProperty<string>? AcceleratorArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("accelerator_arn");
        set => this.WithProperty("accelerator_arn", value);
    }

    /// <summary>
    /// The client_affinity attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClientAffinity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_affinity");
        set => this.WithProperty("client_affinity", value);
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
    /// The protocol attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Protocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
