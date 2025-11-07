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
    public TerraformProperty<string>? AcceleratorArn
    {
        get => GetProperty<TerraformProperty<string>>("accelerator_arn");
        set => this.WithProperty("accelerator_arn", value);
    }

    /// <summary>
    /// The client_affinity attribute.
    /// </summary>
    public TerraformProperty<string>? ClientAffinity
    {
        get => GetProperty<TerraformProperty<string>>("client_affinity");
        set => this.WithProperty("client_affinity", value);
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
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
