using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_chimesdkvoice_global_settings resource.
/// </summary>
public class AwsChimesdkvoiceGlobalSettings : TerraformResource
{
    public AwsChimesdkvoiceGlobalSettings(string name) : base("aws_chimesdkvoice_global_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

}
