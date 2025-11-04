using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iot_thing resource.
/// </summary>
public class AwsIotThing : TerraformResource
{
    public AwsIotThing(string name) : base("aws_iot_thing", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("default_client_id");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    public Dictionary<string, string>? Attributes
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("attributes")?.Value;
        set => this.WithProperty("attributes", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The thing_type_name attribute.
    /// </summary>
    public string? ThingTypeName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("thing_type_name")?.Value;
        set => this.WithProperty("thing_type_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The default_client_id attribute.
    /// </summary>
    public TerraformExpression DefaultClientId => this["default_client_id"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
