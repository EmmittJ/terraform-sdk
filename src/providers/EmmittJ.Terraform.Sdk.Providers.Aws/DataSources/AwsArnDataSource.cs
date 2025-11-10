using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_arn.
/// </summary>
public class AwsArnDataSource : TerraformDataSource
{
    public AwsArnDataSource(string name) : base("aws_arn", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("account");
        this.WithOutput("partition");
        this.WithOutput("region");
        this.WithOutput("resource");
        this.WithOutput("service");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("arn");
        set => this.WithProperty("arn", value);
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
    /// The account attribute.
    /// </summary>
    public TerraformExpression Account => this["account"];

    /// <summary>
    /// The partition attribute.
    /// </summary>
    public TerraformExpression Partition => this["partition"];

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformExpression Region => this["region"];

    /// <summary>
    /// The resource attribute.
    /// </summary>
    public TerraformExpression Resource => this["resource"];

    /// <summary>
    /// The service attribute.
    /// </summary>
    public TerraformExpression Service => this["service"];

}
