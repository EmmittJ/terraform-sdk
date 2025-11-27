using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for assume_role in AwsProvider.
/// Nesting mode: list
/// </summary>
public class AwsProviderAssumeRoleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "assume_role";

    /// <summary>
    /// The duration, between 15 minutes and 12 hours, of the role session. Valid time units are ns, us (or &#181;s), ms, s, h, or m.
    /// </summary>
    public TerraformValue<string>? Duration
    {
        get => new TerraformReference<string>(this, "duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// A unique identifier that might be required when you assume a role in another account.
    /// </summary>
    public TerraformValue<string>? ExternalId
    {
        get => new TerraformReference<string>(this, "external_id");
        set => SetArgument("external_id", value);
    }

    /// <summary>
    /// IAM Policy JSON describing further restricting permissions for the IAM Role being assumed.
    /// </summary>
    public TerraformValue<string>? Policy
    {
        get => new TerraformReference<string>(this, "policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// Amazon Resource Names (ARNs) of IAM Policies describing further restricting permissions for the IAM Role being assumed.
    /// </summary>
    public TerraformSet<string>? PolicyArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "policy_arns").ResolveNodes(ctx));
        set => SetArgument("policy_arns", value);
    }

    /// <summary>
    /// Amazon Resource Name (ARN) of an IAM Role to assume prior to making API calls.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// An identifier for the assumed role session.
    /// </summary>
    public TerraformValue<string>? SessionName
    {
        get => new TerraformReference<string>(this, "session_name");
        set => SetArgument("session_name", value);
    }

    /// <summary>
    /// Source identity specified by the principal assuming the role.
    /// </summary>
    public TerraformValue<string>? SourceIdentity
    {
        get => new TerraformReference<string>(this, "source_identity");
        set => SetArgument("source_identity", value);
    }

    /// <summary>
    /// Assume role session tags.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Assume role session tag keys to pass to any subsequent sessions.
    /// </summary>
    public TerraformSet<string>? TransitiveTagKeys
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "transitive_tag_keys").ResolveNodes(ctx));
        set => SetArgument("transitive_tag_keys", value);
    }

}


/// <summary>
/// Block type for assume_role_with_web_identity in AwsProvider.
/// Nesting mode: list
/// </summary>
public class AwsProviderAssumeRoleWithWebIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "assume_role_with_web_identity";

    /// <summary>
    /// The duration, between 15 minutes and 12 hours, of the role session. Valid time units are ns, us (or &#181;s), ms, s, h, or m.
    /// </summary>
    public TerraformValue<string>? Duration
    {
        get => new TerraformReference<string>(this, "duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// IAM Policy JSON describing further restricting permissions for the IAM Role being assumed.
    /// </summary>
    public TerraformValue<string>? Policy
    {
        get => new TerraformReference<string>(this, "policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// Amazon Resource Names (ARNs) of IAM Policies describing further restricting permissions for the IAM Role being assumed.
    /// </summary>
    public TerraformSet<string>? PolicyArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "policy_arns").ResolveNodes(ctx));
        set => SetArgument("policy_arns", value);
    }

    /// <summary>
    /// Amazon Resource Name (ARN) of an IAM Role to assume prior to making API calls.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// An identifier for the assumed role session.
    /// </summary>
    public TerraformValue<string>? SessionName
    {
        get => new TerraformReference<string>(this, "session_name");
        set => SetArgument("session_name", value);
    }

    /// <summary>
    /// The web_identity_token attribute.
    /// </summary>
    public TerraformValue<string>? WebIdentityToken
    {
        get => new TerraformReference<string>(this, "web_identity_token");
        set => SetArgument("web_identity_token", value);
    }

    /// <summary>
    /// The web_identity_token_file attribute.
    /// </summary>
    public TerraformValue<string>? WebIdentityTokenFile
    {
        get => new TerraformReference<string>(this, "web_identity_token_file");
        set => SetArgument("web_identity_token_file", value);
    }

}


/// <summary>
/// Block type for default_tags in AwsProvider.
/// Nesting mode: list
/// </summary>
public class AwsProviderDefaultTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_tags";

    /// <summary>
    /// Resource tags to default across all resources. Can also be configured with environment variables like `TF_AWS_DEFAULT_TAGS_&amp;lt;tag_name&amp;gt;`.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

}


/// <summary>
/// Block type for endpoints in AwsProvider.
/// Nesting mode: set
/// </summary>
public class AwsProviderEndpointsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "endpoints";

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Accessanalyzer
    {
        get => new TerraformReference<string>(this, "accessanalyzer");
        set => SetArgument("accessanalyzer", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Account
    {
        get => new TerraformReference<string>(this, "account");
        set => SetArgument("account", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Acm
    {
        get => new TerraformReference<string>(this, "acm");
        set => SetArgument("acm", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Acmpca
    {
        get => new TerraformReference<string>(this, "acmpca");
        set => SetArgument("acmpca", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Amg
    {
        get => new TerraformReference<string>(this, "amg");
        set => SetArgument("amg", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Amp
    {
        get => new TerraformReference<string>(this, "amp");
        set => SetArgument("amp", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Amplify
    {
        get => new TerraformReference<string>(this, "amplify");
        set => SetArgument("amplify", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Apigateway
    {
        get => new TerraformReference<string>(this, "apigateway");
        set => SetArgument("apigateway", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Apigatewayv2
    {
        get => new TerraformReference<string>(this, "apigatewayv2");
        set => SetArgument("apigatewayv2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Appautoscaling
    {
        get => new TerraformReference<string>(this, "appautoscaling");
        set => SetArgument("appautoscaling", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Appconfig
    {
        get => new TerraformReference<string>(this, "appconfig");
        set => SetArgument("appconfig", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Appfabric
    {
        get => new TerraformReference<string>(this, "appfabric");
        set => SetArgument("appfabric", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Appflow
    {
        get => new TerraformReference<string>(this, "appflow");
        set => SetArgument("appflow", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Appintegrations
    {
        get => new TerraformReference<string>(this, "appintegrations");
        set => SetArgument("appintegrations", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Appintegrationsservice
    {
        get => new TerraformReference<string>(this, "appintegrationsservice");
        set => SetArgument("appintegrationsservice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Applicationautoscaling
    {
        get => new TerraformReference<string>(this, "applicationautoscaling");
        set => SetArgument("applicationautoscaling", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Applicationinsights
    {
        get => new TerraformReference<string>(this, "applicationinsights");
        set => SetArgument("applicationinsights", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Applicationsignals
    {
        get => new TerraformReference<string>(this, "applicationsignals");
        set => SetArgument("applicationsignals", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Appmesh
    {
        get => new TerraformReference<string>(this, "appmesh");
        set => SetArgument("appmesh", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Appregistry
    {
        get => new TerraformReference<string>(this, "appregistry");
        set => SetArgument("appregistry", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Apprunner
    {
        get => new TerraformReference<string>(this, "apprunner");
        set => SetArgument("apprunner", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Appstream
    {
        get => new TerraformReference<string>(this, "appstream");
        set => SetArgument("appstream", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Appsync
    {
        get => new TerraformReference<string>(this, "appsync");
        set => SetArgument("appsync", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Arcregionswitch
    {
        get => new TerraformReference<string>(this, "arcregionswitch");
        set => SetArgument("arcregionswitch", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Athena
    {
        get => new TerraformReference<string>(this, "athena");
        set => SetArgument("athena", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Auditmanager
    {
        get => new TerraformReference<string>(this, "auditmanager");
        set => SetArgument("auditmanager", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Autoscaling
    {
        get => new TerraformReference<string>(this, "autoscaling");
        set => SetArgument("autoscaling", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Autoscalingplans
    {
        get => new TerraformReference<string>(this, "autoscalingplans");
        set => SetArgument("autoscalingplans", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Backup
    {
        get => new TerraformReference<string>(this, "backup");
        set => SetArgument("backup", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Batch
    {
        get => new TerraformReference<string>(this, "batch");
        set => SetArgument("batch", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Bcmdataexports
    {
        get => new TerraformReference<string>(this, "bcmdataexports");
        set => SetArgument("bcmdataexports", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Beanstalk
    {
        get => new TerraformReference<string>(this, "beanstalk");
        set => SetArgument("beanstalk", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Bedrock
    {
        get => new TerraformReference<string>(this, "bedrock");
        set => SetArgument("bedrock", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Bedrockagent
    {
        get => new TerraformReference<string>(this, "bedrockagent");
        set => SetArgument("bedrockagent", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Bedrockagentcore
    {
        get => new TerraformReference<string>(this, "bedrockagentcore");
        set => SetArgument("bedrockagentcore", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Billing
    {
        get => new TerraformReference<string>(this, "billing");
        set => SetArgument("billing", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Budgets
    {
        get => new TerraformReference<string>(this, "budgets");
        set => SetArgument("budgets", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ce
    {
        get => new TerraformReference<string>(this, "ce");
        set => SetArgument("ce", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Chatbot
    {
        get => new TerraformReference<string>(this, "chatbot");
        set => SetArgument("chatbot", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Chime
    {
        get => new TerraformReference<string>(this, "chime");
        set => SetArgument("chime", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Chimesdkmediapipelines
    {
        get => new TerraformReference<string>(this, "chimesdkmediapipelines");
        set => SetArgument("chimesdkmediapipelines", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Chimesdkvoice
    {
        get => new TerraformReference<string>(this, "chimesdkvoice");
        set => SetArgument("chimesdkvoice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cleanrooms
    {
        get => new TerraformReference<string>(this, "cleanrooms");
        set => SetArgument("cleanrooms", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloud9
    {
        get => new TerraformReference<string>(this, "cloud9");
        set => SetArgument("cloud9", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudcontrol
    {
        get => new TerraformReference<string>(this, "cloudcontrol");
        set => SetArgument("cloudcontrol", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudcontrolapi
    {
        get => new TerraformReference<string>(this, "cloudcontrolapi");
        set => SetArgument("cloudcontrolapi", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudformation
    {
        get => new TerraformReference<string>(this, "cloudformation");
        set => SetArgument("cloudformation", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudfront
    {
        get => new TerraformReference<string>(this, "cloudfront");
        set => SetArgument("cloudfront", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudfrontkeyvaluestore
    {
        get => new TerraformReference<string>(this, "cloudfrontkeyvaluestore");
        set => SetArgument("cloudfrontkeyvaluestore", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudhsm
    {
        get => new TerraformReference<string>(this, "cloudhsm");
        set => SetArgument("cloudhsm", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudhsmv2
    {
        get => new TerraformReference<string>(this, "cloudhsmv2");
        set => SetArgument("cloudhsmv2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudsearch
    {
        get => new TerraformReference<string>(this, "cloudsearch");
        set => SetArgument("cloudsearch", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudtrail
    {
        get => new TerraformReference<string>(this, "cloudtrail");
        set => SetArgument("cloudtrail", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudwatch
    {
        get => new TerraformReference<string>(this, "cloudwatch");
        set => SetArgument("cloudwatch", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudwatchevents
    {
        get => new TerraformReference<string>(this, "cloudwatchevents");
        set => SetArgument("cloudwatchevents", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudwatchevidently
    {
        get => new TerraformReference<string>(this, "cloudwatchevidently");
        set => SetArgument("cloudwatchevidently", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudwatchlog
    {
        get => new TerraformReference<string>(this, "cloudwatchlog");
        set => SetArgument("cloudwatchlog", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudwatchlogs
    {
        get => new TerraformReference<string>(this, "cloudwatchlogs");
        set => SetArgument("cloudwatchlogs", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudwatchobservabilityaccessmanager
    {
        get => new TerraformReference<string>(this, "cloudwatchobservabilityaccessmanager");
        set => SetArgument("cloudwatchobservabilityaccessmanager", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudwatchrum
    {
        get => new TerraformReference<string>(this, "cloudwatchrum");
        set => SetArgument("cloudwatchrum", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Codeartifact
    {
        get => new TerraformReference<string>(this, "codeartifact");
        set => SetArgument("codeartifact", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Codebuild
    {
        get => new TerraformReference<string>(this, "codebuild");
        set => SetArgument("codebuild", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Codecatalyst
    {
        get => new TerraformReference<string>(this, "codecatalyst");
        set => SetArgument("codecatalyst", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Codecommit
    {
        get => new TerraformReference<string>(this, "codecommit");
        set => SetArgument("codecommit", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Codeconnections
    {
        get => new TerraformReference<string>(this, "codeconnections");
        set => SetArgument("codeconnections", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Codedeploy
    {
        get => new TerraformReference<string>(this, "codedeploy");
        set => SetArgument("codedeploy", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Codeguruprofiler
    {
        get => new TerraformReference<string>(this, "codeguruprofiler");
        set => SetArgument("codeguruprofiler", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Codegurureviewer
    {
        get => new TerraformReference<string>(this, "codegurureviewer");
        set => SetArgument("codegurureviewer", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Codepipeline
    {
        get => new TerraformReference<string>(this, "codepipeline");
        set => SetArgument("codepipeline", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Codestarconnections
    {
        get => new TerraformReference<string>(this, "codestarconnections");
        set => SetArgument("codestarconnections", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Codestarnotifications
    {
        get => new TerraformReference<string>(this, "codestarnotifications");
        set => SetArgument("codestarnotifications", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cognitoidentity
    {
        get => new TerraformReference<string>(this, "cognitoidentity");
        set => SetArgument("cognitoidentity", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cognitoidentityprovider
    {
        get => new TerraformReference<string>(this, "cognitoidentityprovider");
        set => SetArgument("cognitoidentityprovider", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cognitoidp
    {
        get => new TerraformReference<string>(this, "cognitoidp");
        set => SetArgument("cognitoidp", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Comprehend
    {
        get => new TerraformReference<string>(this, "comprehend");
        set => SetArgument("comprehend", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Computeoptimizer
    {
        get => new TerraformReference<string>(this, "computeoptimizer");
        set => SetArgument("computeoptimizer", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Config
    {
        get => new TerraformReference<string>(this, "config");
        set => SetArgument("config", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Configservice
    {
        get => new TerraformReference<string>(this, "configservice");
        set => SetArgument("configservice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Connect
    {
        get => new TerraformReference<string>(this, "connect");
        set => SetArgument("connect", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Connectcases
    {
        get => new TerraformReference<string>(this, "connectcases");
        set => SetArgument("connectcases", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Controltower
    {
        get => new TerraformReference<string>(this, "controltower");
        set => SetArgument("controltower", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Costandusagereportservice
    {
        get => new TerraformReference<string>(this, "costandusagereportservice");
        set => SetArgument("costandusagereportservice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Costexplorer
    {
        get => new TerraformReference<string>(this, "costexplorer");
        set => SetArgument("costexplorer", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Costoptimizationhub
    {
        get => new TerraformReference<string>(this, "costoptimizationhub");
        set => SetArgument("costoptimizationhub", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cur
    {
        get => new TerraformReference<string>(this, "cur");
        set => SetArgument("cur", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Customerprofiles
    {
        get => new TerraformReference<string>(this, "customerprofiles");
        set => SetArgument("customerprofiles", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Databasemigration
    {
        get => new TerraformReference<string>(this, "databasemigration");
        set => SetArgument("databasemigration", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Databasemigrationservice
    {
        get => new TerraformReference<string>(this, "databasemigrationservice");
        set => SetArgument("databasemigrationservice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Databrew
    {
        get => new TerraformReference<string>(this, "databrew");
        set => SetArgument("databrew", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Dataexchange
    {
        get => new TerraformReference<string>(this, "dataexchange");
        set => SetArgument("dataexchange", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Datapipeline
    {
        get => new TerraformReference<string>(this, "datapipeline");
        set => SetArgument("datapipeline", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Datasync
    {
        get => new TerraformReference<string>(this, "datasync");
        set => SetArgument("datasync", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Datazone
    {
        get => new TerraformReference<string>(this, "datazone");
        set => SetArgument("datazone", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Dax
    {
        get => new TerraformReference<string>(this, "dax");
        set => SetArgument("dax", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Deploy
    {
        get => new TerraformReference<string>(this, "deploy");
        set => SetArgument("deploy", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Detective
    {
        get => new TerraformReference<string>(this, "detective");
        set => SetArgument("detective", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Devicefarm
    {
        get => new TerraformReference<string>(this, "devicefarm");
        set => SetArgument("devicefarm", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Devopsguru
    {
        get => new TerraformReference<string>(this, "devopsguru");
        set => SetArgument("devopsguru", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Directconnect
    {
        get => new TerraformReference<string>(this, "directconnect");
        set => SetArgument("directconnect", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Directoryservice
    {
        get => new TerraformReference<string>(this, "directoryservice");
        set => SetArgument("directoryservice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Dlm
    {
        get => new TerraformReference<string>(this, "dlm");
        set => SetArgument("dlm", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Dms
    {
        get => new TerraformReference<string>(this, "dms");
        set => SetArgument("dms", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Docdb
    {
        get => new TerraformReference<string>(this, "docdb");
        set => SetArgument("docdb", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Docdbelastic
    {
        get => new TerraformReference<string>(this, "docdbelastic");
        set => SetArgument("docdbelastic", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Drs
    {
        get => new TerraformReference<string>(this, "drs");
        set => SetArgument("drs", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ds
    {
        get => new TerraformReference<string>(this, "ds");
        set => SetArgument("ds", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Dsql
    {
        get => new TerraformReference<string>(this, "dsql");
        set => SetArgument("dsql", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Dynamodb
    {
        get => new TerraformReference<string>(this, "dynamodb");
        set => SetArgument("dynamodb", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ec2
    {
        get => new TerraformReference<string>(this, "ec2");
        set => SetArgument("ec2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ecr
    {
        get => new TerraformReference<string>(this, "ecr");
        set => SetArgument("ecr", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ecrpublic
    {
        get => new TerraformReference<string>(this, "ecrpublic");
        set => SetArgument("ecrpublic", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ecs
    {
        get => new TerraformReference<string>(this, "ecs");
        set => SetArgument("ecs", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Efs
    {
        get => new TerraformReference<string>(this, "efs");
        set => SetArgument("efs", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Eks
    {
        get => new TerraformReference<string>(this, "eks");
        set => SetArgument("eks", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Elasticache
    {
        get => new TerraformReference<string>(this, "elasticache");
        set => SetArgument("elasticache", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Elasticbeanstalk
    {
        get => new TerraformReference<string>(this, "elasticbeanstalk");
        set => SetArgument("elasticbeanstalk", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Elasticloadbalancing
    {
        get => new TerraformReference<string>(this, "elasticloadbalancing");
        set => SetArgument("elasticloadbalancing", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Elasticloadbalancingv2
    {
        get => new TerraformReference<string>(this, "elasticloadbalancingv2");
        set => SetArgument("elasticloadbalancingv2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Elasticsearch
    {
        get => new TerraformReference<string>(this, "elasticsearch");
        set => SetArgument("elasticsearch", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Elasticsearchservice
    {
        get => new TerraformReference<string>(this, "elasticsearchservice");
        set => SetArgument("elasticsearchservice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Elastictranscoder
    {
        get => new TerraformReference<string>(this, "elastictranscoder");
        set => SetArgument("elastictranscoder", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Elb
    {
        get => new TerraformReference<string>(this, "elb");
        set => SetArgument("elb", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Elbv2
    {
        get => new TerraformReference<string>(this, "elbv2");
        set => SetArgument("elbv2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Emr
    {
        get => new TerraformReference<string>(this, "emr");
        set => SetArgument("emr", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Emrcontainers
    {
        get => new TerraformReference<string>(this, "emrcontainers");
        set => SetArgument("emrcontainers", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Emrserverless
    {
        get => new TerraformReference<string>(this, "emrserverless");
        set => SetArgument("emrserverless", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Es
    {
        get => new TerraformReference<string>(this, "es");
        set => SetArgument("es", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Eventbridge
    {
        get => new TerraformReference<string>(this, "eventbridge");
        set => SetArgument("eventbridge", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Events
    {
        get => new TerraformReference<string>(this, "events");
        set => SetArgument("events", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Evidently
    {
        get => new TerraformReference<string>(this, "evidently");
        set => SetArgument("evidently", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Evs
    {
        get => new TerraformReference<string>(this, "evs");
        set => SetArgument("evs", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Finspace
    {
        get => new TerraformReference<string>(this, "finspace");
        set => SetArgument("finspace", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Firehose
    {
        get => new TerraformReference<string>(this, "firehose");
        set => SetArgument("firehose", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Fis
    {
        get => new TerraformReference<string>(this, "fis");
        set => SetArgument("fis", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Fms
    {
        get => new TerraformReference<string>(this, "fms");
        set => SetArgument("fms", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Fsx
    {
        get => new TerraformReference<string>(this, "fsx");
        set => SetArgument("fsx", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Gamelift
    {
        get => new TerraformReference<string>(this, "gamelift");
        set => SetArgument("gamelift", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Glacier
    {
        get => new TerraformReference<string>(this, "glacier");
        set => SetArgument("glacier", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Globalaccelerator
    {
        get => new TerraformReference<string>(this, "globalaccelerator");
        set => SetArgument("globalaccelerator", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Glue
    {
        get => new TerraformReference<string>(this, "glue");
        set => SetArgument("glue", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Gluedatabrew
    {
        get => new TerraformReference<string>(this, "gluedatabrew");
        set => SetArgument("gluedatabrew", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Grafana
    {
        get => new TerraformReference<string>(this, "grafana");
        set => SetArgument("grafana", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Greengrass
    {
        get => new TerraformReference<string>(this, "greengrass");
        set => SetArgument("greengrass", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Groundstation
    {
        get => new TerraformReference<string>(this, "groundstation");
        set => SetArgument("groundstation", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Guardduty
    {
        get => new TerraformReference<string>(this, "guardduty");
        set => SetArgument("guardduty", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Healthlake
    {
        get => new TerraformReference<string>(this, "healthlake");
        set => SetArgument("healthlake", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Iam
    {
        get => new TerraformReference<string>(this, "iam");
        set => SetArgument("iam", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Identitystore
    {
        get => new TerraformReference<string>(this, "identitystore");
        set => SetArgument("identitystore", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Imagebuilder
    {
        get => new TerraformReference<string>(this, "imagebuilder");
        set => SetArgument("imagebuilder", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Inspector
    {
        get => new TerraformReference<string>(this, "inspector");
        set => SetArgument("inspector", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Inspector2
    {
        get => new TerraformReference<string>(this, "inspector2");
        set => SetArgument("inspector2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Inspectorv2
    {
        get => new TerraformReference<string>(this, "inspectorv2");
        set => SetArgument("inspectorv2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Internetmonitor
    {
        get => new TerraformReference<string>(this, "internetmonitor");
        set => SetArgument("internetmonitor", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Invoicing
    {
        get => new TerraformReference<string>(this, "invoicing");
        set => SetArgument("invoicing", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Iot
    {
        get => new TerraformReference<string>(this, "iot");
        set => SetArgument("iot", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ivs
    {
        get => new TerraformReference<string>(this, "ivs");
        set => SetArgument("ivs", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ivschat
    {
        get => new TerraformReference<string>(this, "ivschat");
        set => SetArgument("ivschat", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Kafka
    {
        get => new TerraformReference<string>(this, "kafka");
        set => SetArgument("kafka", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Kafkaconnect
    {
        get => new TerraformReference<string>(this, "kafkaconnect");
        set => SetArgument("kafkaconnect", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Kendra
    {
        get => new TerraformReference<string>(this, "kendra");
        set => SetArgument("kendra", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Keyspaces
    {
        get => new TerraformReference<string>(this, "keyspaces");
        set => SetArgument("keyspaces", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Kinesis
    {
        get => new TerraformReference<string>(this, "kinesis");
        set => SetArgument("kinesis", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Kinesisanalytics
    {
        get => new TerraformReference<string>(this, "kinesisanalytics");
        set => SetArgument("kinesisanalytics", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Kinesisanalyticsv2
    {
        get => new TerraformReference<string>(this, "kinesisanalyticsv2");
        set => SetArgument("kinesisanalyticsv2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Kinesisvideo
    {
        get => new TerraformReference<string>(this, "kinesisvideo");
        set => SetArgument("kinesisvideo", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Kms
    {
        get => new TerraformReference<string>(this, "kms");
        set => SetArgument("kms", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Lakeformation
    {
        get => new TerraformReference<string>(this, "lakeformation");
        set => SetArgument("lakeformation", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Lambda
    {
        get => new TerraformReference<string>(this, "lambda");
        set => SetArgument("lambda", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Launchwizard
    {
        get => new TerraformReference<string>(this, "launchwizard");
        set => SetArgument("launchwizard", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Lex
    {
        get => new TerraformReference<string>(this, "lex");
        set => SetArgument("lex", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Lexmodelbuilding
    {
        get => new TerraformReference<string>(this, "lexmodelbuilding");
        set => SetArgument("lexmodelbuilding", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Lexmodelbuildingservice
    {
        get => new TerraformReference<string>(this, "lexmodelbuildingservice");
        set => SetArgument("lexmodelbuildingservice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Lexmodels
    {
        get => new TerraformReference<string>(this, "lexmodels");
        set => SetArgument("lexmodels", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Lexmodelsv2
    {
        get => new TerraformReference<string>(this, "lexmodelsv2");
        set => SetArgument("lexmodelsv2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Lexv2models
    {
        get => new TerraformReference<string>(this, "lexv2models");
        set => SetArgument("lexv2models", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Licensemanager
    {
        get => new TerraformReference<string>(this, "licensemanager");
        set => SetArgument("licensemanager", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Lightsail
    {
        get => new TerraformReference<string>(this, "lightsail");
        set => SetArgument("lightsail", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Locationservice
    {
        get => new TerraformReference<string>(this, "locationservice");
        set => SetArgument("locationservice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Logs
    {
        get => new TerraformReference<string>(this, "logs");
        set => SetArgument("logs", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Lookoutmetrics
    {
        get => new TerraformReference<string>(this, "lookoutmetrics");
        set => SetArgument("lookoutmetrics", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? M2
    {
        get => new TerraformReference<string>(this, "m2");
        set => SetArgument("m2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Macie2
    {
        get => new TerraformReference<string>(this, "macie2");
        set => SetArgument("macie2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Managedgrafana
    {
        get => new TerraformReference<string>(this, "managedgrafana");
        set => SetArgument("managedgrafana", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Mediaconnect
    {
        get => new TerraformReference<string>(this, "mediaconnect");
        set => SetArgument("mediaconnect", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Mediaconvert
    {
        get => new TerraformReference<string>(this, "mediaconvert");
        set => SetArgument("mediaconvert", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Medialive
    {
        get => new TerraformReference<string>(this, "medialive");
        set => SetArgument("medialive", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Mediapackage
    {
        get => new TerraformReference<string>(this, "mediapackage");
        set => SetArgument("mediapackage", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Mediapackagev2
    {
        get => new TerraformReference<string>(this, "mediapackagev2");
        set => SetArgument("mediapackagev2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Mediapackagevod
    {
        get => new TerraformReference<string>(this, "mediapackagevod");
        set => SetArgument("mediapackagevod", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Mediastore
    {
        get => new TerraformReference<string>(this, "mediastore");
        set => SetArgument("mediastore", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Memorydb
    {
        get => new TerraformReference<string>(this, "memorydb");
        set => SetArgument("memorydb", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Mgn
    {
        get => new TerraformReference<string>(this, "mgn");
        set => SetArgument("mgn", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Mq
    {
        get => new TerraformReference<string>(this, "mq");
        set => SetArgument("mq", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Msk
    {
        get => new TerraformReference<string>(this, "msk");
        set => SetArgument("msk", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Mwaa
    {
        get => new TerraformReference<string>(this, "mwaa");
        set => SetArgument("mwaa", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Neptune
    {
        get => new TerraformReference<string>(this, "neptune");
        set => SetArgument("neptune", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Neptunegraph
    {
        get => new TerraformReference<string>(this, "neptunegraph");
        set => SetArgument("neptunegraph", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Networkfirewall
    {
        get => new TerraformReference<string>(this, "networkfirewall");
        set => SetArgument("networkfirewall", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Networkflowmonitor
    {
        get => new TerraformReference<string>(this, "networkflowmonitor");
        set => SetArgument("networkflowmonitor", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Networkmanager
    {
        get => new TerraformReference<string>(this, "networkmanager");
        set => SetArgument("networkmanager", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Networkmonitor
    {
        get => new TerraformReference<string>(this, "networkmonitor");
        set => SetArgument("networkmonitor", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Notifications
    {
        get => new TerraformReference<string>(this, "notifications");
        set => SetArgument("notifications", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Notificationscontacts
    {
        get => new TerraformReference<string>(this, "notificationscontacts");
        set => SetArgument("notificationscontacts", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Oam
    {
        get => new TerraformReference<string>(this, "oam");
        set => SetArgument("oam", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Observabilityadmin
    {
        get => new TerraformReference<string>(this, "observabilityadmin");
        set => SetArgument("observabilityadmin", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Odb
    {
        get => new TerraformReference<string>(this, "odb");
        set => SetArgument("odb", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Opensearch
    {
        get => new TerraformReference<string>(this, "opensearch");
        set => SetArgument("opensearch", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Opensearchingestion
    {
        get => new TerraformReference<string>(this, "opensearchingestion");
        set => SetArgument("opensearchingestion", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Opensearchserverless
    {
        get => new TerraformReference<string>(this, "opensearchserverless");
        set => SetArgument("opensearchserverless", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Opensearchservice
    {
        get => new TerraformReference<string>(this, "opensearchservice");
        set => SetArgument("opensearchservice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Organizations
    {
        get => new TerraformReference<string>(this, "organizations");
        set => SetArgument("organizations", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Osis
    {
        get => new TerraformReference<string>(this, "osis");
        set => SetArgument("osis", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Outposts
    {
        get => new TerraformReference<string>(this, "outposts");
        set => SetArgument("outposts", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Paymentcryptography
    {
        get => new TerraformReference<string>(this, "paymentcryptography");
        set => SetArgument("paymentcryptography", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Pcaconnectorad
    {
        get => new TerraformReference<string>(this, "pcaconnectorad");
        set => SetArgument("pcaconnectorad", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Pcs
    {
        get => new TerraformReference<string>(this, "pcs");
        set => SetArgument("pcs", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Pinpoint
    {
        get => new TerraformReference<string>(this, "pinpoint");
        set => SetArgument("pinpoint", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Pinpointsmsvoicev2
    {
        get => new TerraformReference<string>(this, "pinpointsmsvoicev2");
        set => SetArgument("pinpointsmsvoicev2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Pipes
    {
        get => new TerraformReference<string>(this, "pipes");
        set => SetArgument("pipes", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Polly
    {
        get => new TerraformReference<string>(this, "polly");
        set => SetArgument("polly", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Pricing
    {
        get => new TerraformReference<string>(this, "pricing");
        set => SetArgument("pricing", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Prometheus
    {
        get => new TerraformReference<string>(this, "prometheus");
        set => SetArgument("prometheus", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Prometheusservice
    {
        get => new TerraformReference<string>(this, "prometheusservice");
        set => SetArgument("prometheusservice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Qbusiness
    {
        get => new TerraformReference<string>(this, "qbusiness");
        set => SetArgument("qbusiness", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Qldb
    {
        get => new TerraformReference<string>(this, "qldb");
        set => SetArgument("qldb", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Quicksight
    {
        get => new TerraformReference<string>(this, "quicksight");
        set => SetArgument("quicksight", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ram
    {
        get => new TerraformReference<string>(this, "ram");
        set => SetArgument("ram", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Rbin
    {
        get => new TerraformReference<string>(this, "rbin");
        set => SetArgument("rbin", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Rds
    {
        get => new TerraformReference<string>(this, "rds");
        set => SetArgument("rds", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Recyclebin
    {
        get => new TerraformReference<string>(this, "recyclebin");
        set => SetArgument("recyclebin", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Redshift
    {
        get => new TerraformReference<string>(this, "redshift");
        set => SetArgument("redshift", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Redshiftdata
    {
        get => new TerraformReference<string>(this, "redshiftdata");
        set => SetArgument("redshiftdata", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Redshiftdataapiservice
    {
        get => new TerraformReference<string>(this, "redshiftdataapiservice");
        set => SetArgument("redshiftdataapiservice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Redshiftserverless
    {
        get => new TerraformReference<string>(this, "redshiftserverless");
        set => SetArgument("redshiftserverless", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Rekognition
    {
        get => new TerraformReference<string>(this, "rekognition");
        set => SetArgument("rekognition", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Resiliencehub
    {
        get => new TerraformReference<string>(this, "resiliencehub");
        set => SetArgument("resiliencehub", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Resourceexplorer2
    {
        get => new TerraformReference<string>(this, "resourceexplorer2");
        set => SetArgument("resourceexplorer2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Resourcegroups
    {
        get => new TerraformReference<string>(this, "resourcegroups");
        set => SetArgument("resourcegroups", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Resourcegroupstagging
    {
        get => new TerraformReference<string>(this, "resourcegroupstagging");
        set => SetArgument("resourcegroupstagging", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Resourcegroupstaggingapi
    {
        get => new TerraformReference<string>(this, "resourcegroupstaggingapi");
        set => SetArgument("resourcegroupstaggingapi", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Rolesanywhere
    {
        get => new TerraformReference<string>(this, "rolesanywhere");
        set => SetArgument("rolesanywhere", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Route53
    {
        get => new TerraformReference<string>(this, "route53");
        set => SetArgument("route53", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Route53domains
    {
        get => new TerraformReference<string>(this, "route53domains");
        set => SetArgument("route53domains", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Route53profiles
    {
        get => new TerraformReference<string>(this, "route53profiles");
        set => SetArgument("route53profiles", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Route53recoverycontrolconfig
    {
        get => new TerraformReference<string>(this, "route53recoverycontrolconfig");
        set => SetArgument("route53recoverycontrolconfig", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Route53recoveryreadiness
    {
        get => new TerraformReference<string>(this, "route53recoveryreadiness");
        set => SetArgument("route53recoveryreadiness", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Route53resolver
    {
        get => new TerraformReference<string>(this, "route53resolver");
        set => SetArgument("route53resolver", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Rum
    {
        get => new TerraformReference<string>(this, "rum");
        set => SetArgument("rum", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? S3
    {
        get => new TerraformReference<string>(this, "s3");
        set => SetArgument("s3", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? S3api
    {
        get => new TerraformReference<string>(this, "s3api");
        set => SetArgument("s3api", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? S3control
    {
        get => new TerraformReference<string>(this, "s3control");
        set => SetArgument("s3control", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? S3outposts
    {
        get => new TerraformReference<string>(this, "s3outposts");
        set => SetArgument("s3outposts", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? S3tables
    {
        get => new TerraformReference<string>(this, "s3tables");
        set => SetArgument("s3tables", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? S3vectors
    {
        get => new TerraformReference<string>(this, "s3vectors");
        set => SetArgument("s3vectors", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Sagemaker
    {
        get => new TerraformReference<string>(this, "sagemaker");
        set => SetArgument("sagemaker", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Scheduler
    {
        get => new TerraformReference<string>(this, "scheduler");
        set => SetArgument("scheduler", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Schemas
    {
        get => new TerraformReference<string>(this, "schemas");
        set => SetArgument("schemas", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Secretsmanager
    {
        get => new TerraformReference<string>(this, "secretsmanager");
        set => SetArgument("secretsmanager", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Securityhub
    {
        get => new TerraformReference<string>(this, "securityhub");
        set => SetArgument("securityhub", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Securitylake
    {
        get => new TerraformReference<string>(this, "securitylake");
        set => SetArgument("securitylake", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Serverlessapplicationrepository
    {
        get => new TerraformReference<string>(this, "serverlessapplicationrepository");
        set => SetArgument("serverlessapplicationrepository", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Serverlessapprepo
    {
        get => new TerraformReference<string>(this, "serverlessapprepo");
        set => SetArgument("serverlessapprepo", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Serverlessrepo
    {
        get => new TerraformReference<string>(this, "serverlessrepo");
        set => SetArgument("serverlessrepo", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Servicecatalog
    {
        get => new TerraformReference<string>(this, "servicecatalog");
        set => SetArgument("servicecatalog", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Servicecatalogappregistry
    {
        get => new TerraformReference<string>(this, "servicecatalogappregistry");
        set => SetArgument("servicecatalogappregistry", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Servicediscovery
    {
        get => new TerraformReference<string>(this, "servicediscovery");
        set => SetArgument("servicediscovery", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Servicequotas
    {
        get => new TerraformReference<string>(this, "servicequotas");
        set => SetArgument("servicequotas", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ses
    {
        get => new TerraformReference<string>(this, "ses");
        set => SetArgument("ses", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Sesv2
    {
        get => new TerraformReference<string>(this, "sesv2");
        set => SetArgument("sesv2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Sfn
    {
        get => new TerraformReference<string>(this, "sfn");
        set => SetArgument("sfn", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Shield
    {
        get => new TerraformReference<string>(this, "shield");
        set => SetArgument("shield", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Signer
    {
        get => new TerraformReference<string>(this, "signer");
        set => SetArgument("signer", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Sns
    {
        get => new TerraformReference<string>(this, "sns");
        set => SetArgument("sns", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Sqs
    {
        get => new TerraformReference<string>(this, "sqs");
        set => SetArgument("sqs", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ssm
    {
        get => new TerraformReference<string>(this, "ssm");
        set => SetArgument("ssm", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ssmcontacts
    {
        get => new TerraformReference<string>(this, "ssmcontacts");
        set => SetArgument("ssmcontacts", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ssmincidents
    {
        get => new TerraformReference<string>(this, "ssmincidents");
        set => SetArgument("ssmincidents", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ssmquicksetup
    {
        get => new TerraformReference<string>(this, "ssmquicksetup");
        set => SetArgument("ssmquicksetup", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ssmsap
    {
        get => new TerraformReference<string>(this, "ssmsap");
        set => SetArgument("ssmsap", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Sso
    {
        get => new TerraformReference<string>(this, "sso");
        set => SetArgument("sso", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ssoadmin
    {
        get => new TerraformReference<string>(this, "ssoadmin");
        set => SetArgument("ssoadmin", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Stepfunctions
    {
        get => new TerraformReference<string>(this, "stepfunctions");
        set => SetArgument("stepfunctions", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Storagegateway
    {
        get => new TerraformReference<string>(this, "storagegateway");
        set => SetArgument("storagegateway", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Sts
    {
        get => new TerraformReference<string>(this, "sts");
        set => SetArgument("sts", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Swf
    {
        get => new TerraformReference<string>(this, "swf");
        set => SetArgument("swf", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Synthetics
    {
        get => new TerraformReference<string>(this, "synthetics");
        set => SetArgument("synthetics", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Taxsettings
    {
        get => new TerraformReference<string>(this, "taxsettings");
        set => SetArgument("taxsettings", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Timestreaminfluxdb
    {
        get => new TerraformReference<string>(this, "timestreaminfluxdb");
        set => SetArgument("timestreaminfluxdb", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Timestreamquery
    {
        get => new TerraformReference<string>(this, "timestreamquery");
        set => SetArgument("timestreamquery", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Timestreamwrite
    {
        get => new TerraformReference<string>(this, "timestreamwrite");
        set => SetArgument("timestreamwrite", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Transcribe
    {
        get => new TerraformReference<string>(this, "transcribe");
        set => SetArgument("transcribe", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Transcribeservice
    {
        get => new TerraformReference<string>(this, "transcribeservice");
        set => SetArgument("transcribeservice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Transfer
    {
        get => new TerraformReference<string>(this, "transfer");
        set => SetArgument("transfer", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Verifiedpermissions
    {
        get => new TerraformReference<string>(this, "verifiedpermissions");
        set => SetArgument("verifiedpermissions", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Vpclattice
    {
        get => new TerraformReference<string>(this, "vpclattice");
        set => SetArgument("vpclattice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Waf
    {
        get => new TerraformReference<string>(this, "waf");
        set => SetArgument("waf", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Wafregional
    {
        get => new TerraformReference<string>(this, "wafregional");
        set => SetArgument("wafregional", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Wafv2
    {
        get => new TerraformReference<string>(this, "wafv2");
        set => SetArgument("wafv2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Wellarchitected
    {
        get => new TerraformReference<string>(this, "wellarchitected");
        set => SetArgument("wellarchitected", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Workmail
    {
        get => new TerraformReference<string>(this, "workmail");
        set => SetArgument("workmail", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Workspaces
    {
        get => new TerraformReference<string>(this, "workspaces");
        set => SetArgument("workspaces", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Workspacesweb
    {
        get => new TerraformReference<string>(this, "workspacesweb");
        set => SetArgument("workspacesweb", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Xray
    {
        get => new TerraformReference<string>(this, "xray");
        set => SetArgument("xray", value);
    }

}


/// <summary>
/// Block type for ignore_tags in AwsProvider.
/// Nesting mode: list
/// </summary>
public class AwsProviderIgnoreTagsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ignore_tags";

    /// <summary>
    /// Resource tag key prefixes to ignore across all resources. Can also be configured with the TF_AWS_IGNORE_TAGS_KEY_PREFIXES environment variable.
    /// </summary>
    public TerraformSet<string>? KeyPrefixes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "key_prefixes").ResolveNodes(ctx));
        set => SetArgument("key_prefixes", value);
    }

    /// <summary>
    /// Resource tag keys to ignore across all resources. Can also be configured with the TF_AWS_IGNORE_TAGS_KEYS environment variable.
    /// </summary>
    public TerraformSet<string>? KeysAttribute
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "keys").ResolveNodes(ctx));
        set => SetArgument("keys", value);
    }

}


/// <summary>
/// Represents the aws Terraform provider.
/// Version: ~&gt; 6.0
/// Resources: 1561
/// Data Sources: 630
/// </summary>
public partial class AwsProvider(string name = "aws") : TerraformProvider(name)
{
    /// <summary>
    /// The access key for API operations. You can retrieve this
    /// from the &#39;Security &amp;amp; Credentials&#39; section of the AWS console.
    /// </summary>
    public TerraformValue<string>? AccessKey
    {
        get => new TerraformReference<string>(this, "access_key");
        set => SetArgument("access_key", value);
    }


    /// <summary>
    /// The allowed_account_ids attribute.
    /// </summary>
    public TerraformSet<string>? AllowedAccountIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_account_ids").ResolveNodes(ctx));
        set => SetArgument("allowed_account_ids", value);
    }


    /// <summary>
    /// File containing custom root and intermediate certificates. Can also be configured using the `AWS_CA_BUNDLE` environment variable. (Setting `ca_bundle` in the shared config file is not supported.)
    /// </summary>
    public TerraformValue<string>? CustomCaBundle
    {
        get => new TerraformReference<string>(this, "custom_ca_bundle");
        set => SetArgument("custom_ca_bundle", value);
    }


    /// <summary>
    /// Address of the EC2 metadata service endpoint to use. Can also be configured using the `AWS_EC2_METADATA_SERVICE_ENDPOINT` environment variable.
    /// </summary>
    public TerraformValue<string>? Ec2MetadataServiceEndpoint
    {
        get => new TerraformReference<string>(this, "ec2_metadata_service_endpoint");
        set => SetArgument("ec2_metadata_service_endpoint", value);
    }


    /// <summary>
    /// Protocol to use with EC2 metadata service endpoint.Valid values are `IPv4` and `IPv6`. Can also be configured using the `AWS_EC2_METADATA_SERVICE_ENDPOINT_MODE` environment variable.
    /// </summary>
    public TerraformValue<string>? Ec2MetadataServiceEndpointMode
    {
        get => new TerraformReference<string>(this, "ec2_metadata_service_endpoint_mode");
        set => SetArgument("ec2_metadata_service_endpoint_mode", value);
    }


    /// <summary>
    /// The forbidden_account_ids attribute.
    /// </summary>
    public TerraformSet<string>? ForbiddenAccountIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "forbidden_account_ids").ResolveNodes(ctx));
        set => SetArgument("forbidden_account_ids", value);
    }


    /// <summary>
    /// URL of a proxy to use for HTTP requests when accessing the AWS API. Can also be set using the `HTTP_PROXY` or `http_proxy` environment variables.
    /// </summary>
    public TerraformValue<string>? HttpProxy
    {
        get => new TerraformReference<string>(this, "http_proxy");
        set => SetArgument("http_proxy", value);
    }


    /// <summary>
    /// URL of a proxy to use for HTTPS requests when accessing the AWS API. Can also be set using the `HTTPS_PROXY` or `https_proxy` environment variables.
    /// </summary>
    public TerraformValue<string>? HttpsProxy
    {
        get => new TerraformReference<string>(this, "https_proxy");
        set => SetArgument("https_proxy", value);
    }


    /// <summary>
    /// Explicitly allow the provider to perform &amp;quot;insecure&amp;quot; SSL requests. If omitted, default value is `false`
    /// </summary>
    public TerraformValue<bool>? Insecure
    {
        get => new TerraformReference<bool>(this, "insecure");
        set => SetArgument("insecure", value);
    }


    /// <summary>
    /// The maximum number of times an AWS API request is
    /// being executed. If the API request still fails, an error is
    /// thrown.
    /// </summary>
    public TerraformValue<double>? MaxRetries
    {
        get => new TerraformReference<double>(this, "max_retries");
        set => SetArgument("max_retries", value);
    }


    /// <summary>
    /// Comma-separated list of hosts that should not use HTTP or HTTPS proxies. Can also be set using the `NO_PROXY` or `no_proxy` environment variables.
    /// </summary>
    public TerraformValue<string>? NoProxy
    {
        get => new TerraformReference<string>(this, "no_proxy");
        set => SetArgument("no_proxy", value);
    }


    /// <summary>
    /// The profile for API operations. If not set, the default profile
    /// created with `aws configure` will be used.
    /// </summary>
    public TerraformValue<string>? Profile
    {
        get => new TerraformReference<string>(this, "profile");
        set => SetArgument("profile", value);
    }


    /// <summary>
    /// The region where AWS operations will take place. Examples
    /// are us-east-1, us-west-2, etc.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }


    /// <summary>
    /// Specifies how retries are attempted. Valid values are `standard` and `adaptive`. Can also be configured using the `AWS_RETRY_MODE` environment variable.
    /// </summary>
    public TerraformValue<string>? RetryMode
    {
        get => new TerraformReference<string>(this, "retry_mode");
        set => SetArgument("retry_mode", value);
    }


    /// <summary>
    /// Specifies whether S3 API calls in the `us-east-1` region use the legacy global endpoint or a regional endpoint. Valid values are `legacy` or `regional`. Can also be configured using the `AWS_S3_US_EAST_1_REGIONAL_ENDPOINT` environment variable or the `s3_us_east_1_regional_endpoint` shared config file parameter
    /// </summary>
    public TerraformValue<string>? S3UsEast1RegionalEndpoint
    {
        get => new TerraformReference<string>(this, "s3_us_east_1_regional_endpoint");
        set => SetArgument("s3_us_east_1_regional_endpoint", value);
    }


    /// <summary>
    /// Set this to true to enable the request to use path-style addressing,
    /// i.e., https://s3.amazonaws.com/BUCKET/KEY. By default, the S3 client will
    /// use virtual hosted bucket addressing when possible
    /// (https://BUCKET.s3.amazonaws.com/KEY). Specific to the Amazon S3 service.
    /// </summary>
    public TerraformValue<bool>? S3UsePathStyle
    {
        get => new TerraformReference<bool>(this, "s3_use_path_style");
        set => SetArgument("s3_use_path_style", value);
    }


    /// <summary>
    /// The secret key for API operations. You can retrieve this
    /// from the &#39;Security &amp;amp; Credentials&#39; section of the AWS console.
    /// </summary>
    public TerraformValue<string>? SecretKey
    {
        get => new TerraformReference<string>(this, "secret_key");
        set => SetArgument("secret_key", value);
    }


    /// <summary>
    /// List of paths to shared config files. If not set, defaults to [~/.aws/config].
    /// </summary>
    public TerraformList<string>? SharedConfigFiles
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "shared_config_files").ResolveNodes(ctx));
        set => SetArgument("shared_config_files", value);
    }


    /// <summary>
    /// List of paths to shared credentials files. If not set, defaults to [~/.aws/credentials].
    /// </summary>
    public TerraformList<string>? SharedCredentialsFiles
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "shared_credentials_files").ResolveNodes(ctx));
        set => SetArgument("shared_credentials_files", value);
    }


    /// <summary>
    /// Skip the credentials validation via STS API. Used for AWS API implementations that do not have STS available/implemented.
    /// </summary>
    public TerraformValue<bool>? SkipCredentialsValidation
    {
        get => new TerraformReference<bool>(this, "skip_credentials_validation");
        set => SetArgument("skip_credentials_validation", value);
    }


    /// <summary>
    /// Skip the AWS Metadata API check. Used for AWS API implementations that do not have a metadata api endpoint.
    /// </summary>
    public TerraformValue<string>? SkipMetadataApiCheck
    {
        get => new TerraformReference<string>(this, "skip_metadata_api_check");
        set => SetArgument("skip_metadata_api_check", value);
    }


    /// <summary>
    /// Skip static validation of region name. Used by users of alternative AWS-like APIs or users w/ access to regions that are not public (yet).
    /// </summary>
    public TerraformValue<bool>? SkipRegionValidation
    {
        get => new TerraformReference<bool>(this, "skip_region_validation");
        set => SetArgument("skip_region_validation", value);
    }


    /// <summary>
    /// Skip requesting the account ID. Used for AWS API implementations that do not have IAM/STS API and/or metadata API.
    /// </summary>
    public TerraformValue<bool>? SkipRequestingAccountId
    {
        get => new TerraformReference<bool>(this, "skip_requesting_account_id");
        set => SetArgument("skip_requesting_account_id", value);
    }


    /// <summary>
    /// The region where AWS STS operations will take place. Examples
    /// are us-east-1 and us-west-2.
    /// </summary>
    public TerraformValue<string>? StsRegion
    {
        get => new TerraformReference<string>(this, "sts_region");
        set => SetArgument("sts_region", value);
    }


    /// <summary>
    /// session token. A session token is only required if you are
    /// using temporary security credentials.
    /// </summary>
    public TerraformValue<string>? Token
    {
        get => new TerraformReference<string>(this, "token");
        set => SetArgument("token", value);
    }


    /// <summary>
    /// The capacity of the AWS SDK&#39;s token bucket rate limiter.
    /// </summary>
    public TerraformValue<double>? TokenBucketRateLimiterCapacity
    {
        get => new TerraformReference<double>(this, "token_bucket_rate_limiter_capacity");
        set => SetArgument("token_bucket_rate_limiter_capacity", value);
    }


    /// <summary>
    /// Resolve an endpoint with DualStack capability
    /// </summary>
    public TerraformValue<bool>? UseDualstackEndpoint
    {
        get => new TerraformReference<bool>(this, "use_dualstack_endpoint");
        set => SetArgument("use_dualstack_endpoint", value);
    }


    /// <summary>
    /// Resolve an endpoint with FIPS capability
    /// </summary>
    public TerraformValue<bool>? UseFipsEndpoint
    {
        get => new TerraformReference<bool>(this, "use_fips_endpoint");
        set => SetArgument("use_fips_endpoint", value);
    }


    /// <summary>
    /// AssumeRole block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsProviderAssumeRoleBlock>? AssumeRole
    {
        get => GetArgument<TerraformList<AwsProviderAssumeRoleBlock>>("assume_role");
        set => SetArgument("assume_role", value);
    }

    /// <summary>
    /// AssumeRoleWithWebIdentity block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsProviderAssumeRoleWithWebIdentityBlock>? AssumeRoleWithWebIdentity
    {
        get => GetArgument<TerraformList<AwsProviderAssumeRoleWithWebIdentityBlock>>("assume_role_with_web_identity");
        set => SetArgument("assume_role_with_web_identity", value);
    }

    /// <summary>
    /// DefaultTags block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsProviderDefaultTagsBlock>? DefaultTags
    {
        get => GetArgument<TerraformList<AwsProviderDefaultTagsBlock>>("default_tags");
        set => SetArgument("default_tags", value);
    }

    /// <summary>
    /// Endpoints block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsProviderEndpointsBlock>? Endpoints
    {
        get => GetArgument<TerraformSet<AwsProviderEndpointsBlock>>("endpoints");
        set => SetArgument("endpoints", value);
    }

    /// <summary>
    /// IgnoreTags block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsProviderIgnoreTagsBlock>? IgnoreTags
    {
        get => GetArgument<TerraformList<AwsProviderIgnoreTagsBlock>>("ignore_tags");
        set => SetArgument("ignore_tags", value);
    }

}
