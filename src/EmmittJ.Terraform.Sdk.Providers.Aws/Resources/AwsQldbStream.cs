using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_qldb_stream resource.
/// </summary>
public class AwsQldbStream : TerraformResource
{
    public AwsQldbStream(string name) : base("aws_qldb_stream", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The exclusive_end_time attribute.
    /// </summary>
    public TerraformProperty<string>? ExclusiveEndTime
    {
        get => GetProperty<TerraformProperty<string>>("exclusive_end_time");
        set => this.WithProperty("exclusive_end_time", value);
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
    /// The inclusive_start_time attribute.
    /// </summary>
    public TerraformProperty<string>? InclusiveStartTime
    {
        get => GetProperty<TerraformProperty<string>>("inclusive_start_time");
        set => this.WithProperty("inclusive_start_time", value);
    }

    /// <summary>
    /// The ledger_name attribute.
    /// </summary>
    public TerraformProperty<string>? LedgerName
    {
        get => GetProperty<TerraformProperty<string>>("ledger_name");
        set => this.WithProperty("ledger_name", value);
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The stream_name attribute.
    /// </summary>
    public TerraformProperty<string>? StreamName
    {
        get => GetProperty<TerraformProperty<string>>("stream_name");
        set => this.WithProperty("stream_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
