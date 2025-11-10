using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_memorydb_user.
/// </summary>
public class AwsMemorydbUserDataSource : TerraformDataSource
{
    public AwsMemorydbUserDataSource(string name) : base("aws_memorydb_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("access_string");
        this.WithOutput("arn");
        this.WithOutput("authentication_mode");
        this.WithOutput("minimum_engine_version");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformProperty<string> UserName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("user_name");
        set => this.WithProperty("user_name", value);
    }

    /// <summary>
    /// The access_string attribute.
    /// </summary>
    public TerraformExpression AccessString => this["access_string"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    public TerraformExpression AuthenticationMode => this["authentication_mode"];

    /// <summary>
    /// The minimum_engine_version attribute.
    /// </summary>
    public TerraformExpression MinimumEngineVersion => this["minimum_engine_version"];

}
