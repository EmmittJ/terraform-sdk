using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_elasticache_user.
/// </summary>
public class AwsElasticacheUserDataSource : TerraformDataSource
{
    public AwsElasticacheUserDataSource(string name) : base("aws_elasticache_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The access_string attribute.
    /// </summary>
    public TerraformProperty<string>? AccessString
    {
        get => GetProperty<TerraformProperty<string>>("access_string");
        set => this.WithProperty("access_string", value);
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformProperty<string>? Engine
    {
        get => GetProperty<TerraformProperty<string>>("engine");
        set => this.WithProperty("engine", value);
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
    /// The no_password_required attribute.
    /// </summary>
    public TerraformProperty<bool>? NoPasswordRequired
    {
        get => GetProperty<TerraformProperty<bool>>("no_password_required");
        set => this.WithProperty("no_password_required", value);
    }

    /// <summary>
    /// The passwords attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Passwords
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("passwords");
        set => this.WithProperty("passwords", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    public TerraformProperty<string>? UserId
    {
        get => GetProperty<TerraformProperty<string>>("user_id");
        set => this.WithProperty("user_id", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformProperty<string>? UserName
    {
        get => GetProperty<TerraformProperty<string>>("user_name");
        set => this.WithProperty("user_name", value);
    }

}
