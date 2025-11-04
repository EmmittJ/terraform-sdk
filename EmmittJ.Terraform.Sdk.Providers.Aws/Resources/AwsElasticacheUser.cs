using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_elasticache_user resource.
/// </summary>
public class AwsElasticacheUser : TerraformResource
{
    public AwsElasticacheUser(string name) : base("aws_elasticache_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The access_string attribute.
    /// </summary>
    public string? AccessString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_string")?.Value;
        set => this.WithProperty("access_string", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public string? Engine
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine")?.Value;
        set => this.WithProperty("engine", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The no_password_required attribute.
    /// </summary>
    public bool? NoPasswordRequired
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("no_password_required")?.Value;
        set => this.WithProperty("no_password_required", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The passwords attribute.
    /// </summary>
    public HashSet<string>? Passwords
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("passwords")?.Value;
        set => this.WithProperty("passwords", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The user_id attribute.
    /// </summary>
    public string? UserId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_id")?.Value;
        set => this.WithProperty("user_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public string? UserName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_name")?.Value;
        set => this.WithProperty("user_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
