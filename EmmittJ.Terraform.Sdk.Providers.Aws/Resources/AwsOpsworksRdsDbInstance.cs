using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_opsworks_rds_db_instance resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AwsOpsworksRdsDbInstance : TerraformResource
{
    public AwsOpsworksRdsDbInstance(string name) : base("aws_opsworks_rds_db_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The db_password attribute.
    /// </summary>
    public string? DbPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_password")?.Value;
        set => this.WithProperty("db_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The db_user attribute.
    /// </summary>
    public string? DbUser
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_user")?.Value;
        set => this.WithProperty("db_user", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The rds_db_instance_arn attribute.
    /// </summary>
    public string? RdsDbInstanceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rds_db_instance_arn")?.Value;
        set => this.WithProperty("rds_db_instance_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The stack_id attribute.
    /// </summary>
    public string? StackId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stack_id")?.Value;
        set => this.WithProperty("stack_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
