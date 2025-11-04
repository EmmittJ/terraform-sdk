using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_main_route_table_association resource.
/// </summary>
public class AwsMainRouteTableAssociation : TerraformResource
{
    public AwsMainRouteTableAssociation(string name) : base("aws_main_route_table_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("original_route_table_id");
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
    /// The route_table_id attribute.
    /// </summary>
    public string? RouteTableId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("route_table_id")?.Value;
        set => this.WithProperty("route_table_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public string? VpcId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_id")?.Value;
        set => this.WithProperty("vpc_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The original_route_table_id attribute.
    /// </summary>
    public TerraformExpression OriginalRouteTableId => this["original_route_table_id"];

}
