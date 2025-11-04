using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_default_route_table resource.
/// </summary>
public class AwsDefaultRouteTable : TerraformResource
{
    public AwsDefaultRouteTable(string name) : base("aws_default_route_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("vpc_id");
    }

    /// <summary>
    /// The default_route_table_id attribute.
    /// </summary>
    public string? DefaultRouteTableId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_route_table_id")?.Value;
        set => this.WithProperty("default_route_table_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The propagating_vgws attribute.
    /// </summary>
    public HashSet<string>? PropagatingVgws
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("propagating_vgws")?.Value;
        set => this.WithProperty("propagating_vgws", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The route attribute.
    /// </summary>
    public HashSet<object>? Route
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<object>>>("route")?.Value;
        set => this.WithProperty("route", value == null ? null : new TerraformLiteralProperty<HashSet<object>>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
