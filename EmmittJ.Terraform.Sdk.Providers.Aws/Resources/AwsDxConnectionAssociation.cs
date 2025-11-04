using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dx_connection_association resource.
/// </summary>
public class AwsDxConnectionAssociation : TerraformResource
{
    public AwsDxConnectionAssociation(string name) : base("aws_dx_connection_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The connection_id attribute.
    /// </summary>
    public string? ConnectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_id")?.Value;
        set => this.WithProperty("connection_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The lag_id attribute.
    /// </summary>
    public string? LagId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lag_id")?.Value;
        set => this.WithProperty("lag_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
