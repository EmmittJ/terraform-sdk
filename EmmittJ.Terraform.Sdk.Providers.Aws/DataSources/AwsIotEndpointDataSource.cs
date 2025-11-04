using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iot_endpoint.
/// </summary>
public class AwsIotEndpointDataSource : TerraformDataSource
{
    public AwsIotEndpointDataSource(string name) : base("aws_iot_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("endpoint_address");
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public string? EndpointType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_type")?.Value;
        set => this.WithProperty("endpoint_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The endpoint_address attribute.
    /// </summary>
    public TerraformExpression EndpointAddress => this["endpoint_address"];

}
