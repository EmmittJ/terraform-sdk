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
        SetOutput("arn");
        SetOutput("created_at");
        SetOutput("id");
        SetOutput("updated_at");
        SetOutput("region");
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    public List<AwsDataexchangeEventActionActionBlock>? Action
    {
        set => SetProperty("action", value);
    }

    /// <summary>
    /// Block for event.
    /// Nesting mode: list
    /// </summary>
    public List<AwsDataexchangeEventActionEventBlock>? Event
    {
        set => SetProperty("event", value);
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
