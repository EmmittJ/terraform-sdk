using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_medialive_input resource.
/// </summary>
public class AwsMedialiveInput : TerraformResource
{
    public AwsMedialiveInput(string name) : base("aws_medialive_input", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("attached_channels");
        this.DeclareOutput("input_class");
        this.DeclareOutput("input_partner_ids");
        this.DeclareOutput("input_source_type");
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
    /// The input_security_groups attribute.
    /// </summary>
    public List<string>? InputSecurityGroups
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("input_security_groups")?.Value;
        set => this.WithProperty("input_security_groups", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The role_arn attribute.
    /// </summary>
    public string? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn")?.Value;
        set => this.WithProperty("role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The attached_channels attribute.
    /// </summary>
    public TerraformExpression AttachedChannels => this["attached_channels"];

    /// <summary>
    /// The input_class attribute.
    /// </summary>
    public TerraformExpression InputClass => this["input_class"];

    /// <summary>
    /// The input_partner_ids attribute.
    /// </summary>
    public TerraformExpression InputPartnerIds => this["input_partner_ids"];

    /// <summary>
    /// The input_source_type attribute.
    /// </summary>
    public TerraformExpression InputSourceType => this["input_source_type"];

}
