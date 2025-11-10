using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action in .
/// Nesting mode: list
/// </summary>
public class AwsDataexchangeEventActionActionBlock : TerraformBlock
{
}

/// <summary>
/// Block type for event in .
/// Nesting mode: list
/// </summary>
public class AwsDataexchangeEventActionEventBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_dataexchange_event_action resource.
/// </summary>
public class AwsDataexchangeEventAction : TerraformResource
{
    public AwsDataexchangeEventAction(string name) : base("aws_dataexchange_event_action", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("created_at");
        this.WithOutput("id");
        this.WithOutput("updated_at");
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
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    public List<AwsDataexchangeEventActionActionBlock>? Action
    {
        get => GetProperty<List<AwsDataexchangeEventActionActionBlock>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// Block for event.
    /// Nesting mode: list
    /// </summary>
    public List<AwsDataexchangeEventActionEventBlock>? Event
    {
        get => GetProperty<List<AwsDataexchangeEventActionEventBlock>>("event");
        set => this.WithProperty("event", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformExpression UpdatedAt => this["updated_at"];

}
