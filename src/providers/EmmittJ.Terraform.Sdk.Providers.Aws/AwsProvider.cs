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
        get => GetArgument<TerraformValue<string>>("duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// A unique identifier that might be required when you assume a role in another account.
    /// </summary>
    public TerraformValue<string>? ExternalId
    {
        get => GetArgument<TerraformValue<string>>("external_id");
        set => SetArgument("external_id", value);
    }

    /// <summary>
    /// IAM Policy JSON describing further restricting permissions for the IAM Role being assumed.
    /// </summary>
    public TerraformValue<string>? Policy
    {
        get => GetArgument<TerraformValue<string>>("policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// Amazon Resource Names (ARNs) of IAM Policies describing further restricting permissions for the IAM Role being assumed.
    /// </summary>
    public TerraformSet<string>? PolicyArns
    {
        get => GetArgument<TerraformSet<string>>("policy_arns");
        set => SetArgument("policy_arns", value);
    }

    /// <summary>
    /// Amazon Resource Name (ARN) of an IAM Role to assume prior to making API calls.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => GetArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// An identifier for the assumed role session.
    /// </summary>
    public TerraformValue<string>? SessionName
    {
        get => GetArgument<TerraformValue<string>>("session_name");
        set => SetArgument("session_name", value);
    }

    /// <summary>
    /// Source identity specified by the principal assuming the role.
    /// </summary>
    public TerraformValue<string>? SourceIdentity
    {
        get => GetArgument<TerraformValue<string>>("source_identity");
        set => SetArgument("source_identity", value);
    }

    /// <summary>
    /// Assume role session tags.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Assume role session tag keys to pass to any subsequent sessions.
    /// </summary>
    public TerraformSet<string>? TransitiveTagKeys
    {
        get => GetArgument<TerraformSet<string>>("transitive_tag_keys");
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
        get => GetArgument<TerraformValue<string>>("duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// IAM Policy JSON describing further restricting permissions for the IAM Role being assumed.
    /// </summary>
    public TerraformValue<string>? Policy
    {
        get => GetArgument<TerraformValue<string>>("policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// Amazon Resource Names (ARNs) of IAM Policies describing further restricting permissions for the IAM Role being assumed.
    /// </summary>
    public TerraformSet<string>? PolicyArns
    {
        get => GetArgument<TerraformSet<string>>("policy_arns");
        set => SetArgument("policy_arns", value);
    }

    /// <summary>
    /// Amazon Resource Name (ARN) of an IAM Role to assume prior to making API calls.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => GetArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// An identifier for the assumed role session.
    /// </summary>
    public TerraformValue<string>? SessionName
    {
        get => GetArgument<TerraformValue<string>>("session_name");
        set => SetArgument("session_name", value);
    }

    /// <summary>
    /// The web_identity_token attribute.
    /// </summary>
    public TerraformValue<string>? WebIdentityToken
    {
        get => GetArgument<TerraformValue<string>>("web_identity_token");
        set => SetArgument("web_identity_token", value);
    }

    /// <summary>
    /// The web_identity_token_file attribute.
    /// </summary>
    public TerraformValue<string>? WebIdentityTokenFile
    {
        get => GetArgument<TerraformValue<string>>("web_identity_token_file");
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
        get => GetArgument<TerraformMap<string>>("tags");
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
        get => GetArgument<TerraformValue<string>>("accessanalyzer");
        set => SetArgument("accessanalyzer", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Account
    {
        get => GetArgument<TerraformValue<string>>("account");
        set => SetArgument("account", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Acm
    {
        get => GetArgument<TerraformValue<string>>("acm");
        set => SetArgument("acm", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Acmpca
    {
        get => GetArgument<TerraformValue<string>>("acmpca");
        set => SetArgument("acmpca", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Amg
    {
        get => GetArgument<TerraformValue<string>>("amg");
        set => SetArgument("amg", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Amp
    {
        get => GetArgument<TerraformValue<string>>("amp");
        set => SetArgument("amp", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Amplify
    {
        get => GetArgument<TerraformValue<string>>("amplify");
        set => SetArgument("amplify", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Apigateway
    {
        get => GetArgument<TerraformValue<string>>("apigateway");
        set => SetArgument("apigateway", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Apigatewayv2
    {
        get => GetArgument<TerraformValue<string>>("apigatewayv2");
        set => SetArgument("apigatewayv2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Appautoscaling
    {
        get => GetArgument<TerraformValue<string>>("appautoscaling");
        set => SetArgument("appautoscaling", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Appconfig
    {
        get => GetArgument<TerraformValue<string>>("appconfig");
        set => SetArgument("appconfig", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Appfabric
    {
        get => GetArgument<TerraformValue<string>>("appfabric");
        set => SetArgument("appfabric", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Appflow
    {
        get => GetArgument<TerraformValue<string>>("appflow");
        set => SetArgument("appflow", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Appintegrations
    {
        get => GetArgument<TerraformValue<string>>("appintegrations");
        set => SetArgument("appintegrations", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Appintegrationsservice
    {
        get => GetArgument<TerraformValue<string>>("appintegrationsservice");
        set => SetArgument("appintegrationsservice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Applicationautoscaling
    {
        get => GetArgument<TerraformValue<string>>("applicationautoscaling");
        set => SetArgument("applicationautoscaling", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Applicationinsights
    {
        get => GetArgument<TerraformValue<string>>("applicationinsights");
        set => SetArgument("applicationinsights", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Applicationsignals
    {
        get => GetArgument<TerraformValue<string>>("applicationsignals");
        set => SetArgument("applicationsignals", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Appmesh
    {
        get => GetArgument<TerraformValue<string>>("appmesh");
        set => SetArgument("appmesh", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Appregistry
    {
        get => GetArgument<TerraformValue<string>>("appregistry");
        set => SetArgument("appregistry", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Apprunner
    {
        get => GetArgument<TerraformValue<string>>("apprunner");
        set => SetArgument("apprunner", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Appstream
    {
        get => GetArgument<TerraformValue<string>>("appstream");
        set => SetArgument("appstream", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Appsync
    {
        get => GetArgument<TerraformValue<string>>("appsync");
        set => SetArgument("appsync", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Arcregionswitch
    {
        get => GetArgument<TerraformValue<string>>("arcregionswitch");
        set => SetArgument("arcregionswitch", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Athena
    {
        get => GetArgument<TerraformValue<string>>("athena");
        set => SetArgument("athena", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Auditmanager
    {
        get => GetArgument<TerraformValue<string>>("auditmanager");
        set => SetArgument("auditmanager", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Autoscaling
    {
        get => GetArgument<TerraformValue<string>>("autoscaling");
        set => SetArgument("autoscaling", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Autoscalingplans
    {
        get => GetArgument<TerraformValue<string>>("autoscalingplans");
        set => SetArgument("autoscalingplans", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Backup
    {
        get => GetArgument<TerraformValue<string>>("backup");
        set => SetArgument("backup", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Batch
    {
        get => GetArgument<TerraformValue<string>>("batch");
        set => SetArgument("batch", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Bcmdataexports
    {
        get => GetArgument<TerraformValue<string>>("bcmdataexports");
        set => SetArgument("bcmdataexports", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Beanstalk
    {
        get => GetArgument<TerraformValue<string>>("beanstalk");
        set => SetArgument("beanstalk", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Bedrock
    {
        get => GetArgument<TerraformValue<string>>("bedrock");
        set => SetArgument("bedrock", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Bedrockagent
    {
        get => GetArgument<TerraformValue<string>>("bedrockagent");
        set => SetArgument("bedrockagent", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Bedrockagentcore
    {
        get => GetArgument<TerraformValue<string>>("bedrockagentcore");
        set => SetArgument("bedrockagentcore", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Billing
    {
        get => GetArgument<TerraformValue<string>>("billing");
        set => SetArgument("billing", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Budgets
    {
        get => GetArgument<TerraformValue<string>>("budgets");
        set => SetArgument("budgets", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ce
    {
        get => GetArgument<TerraformValue<string>>("ce");
        set => SetArgument("ce", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Chatbot
    {
        get => GetArgument<TerraformValue<string>>("chatbot");
        set => SetArgument("chatbot", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Chime
    {
        get => GetArgument<TerraformValue<string>>("chime");
        set => SetArgument("chime", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Chimesdkmediapipelines
    {
        get => GetArgument<TerraformValue<string>>("chimesdkmediapipelines");
        set => SetArgument("chimesdkmediapipelines", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Chimesdkvoice
    {
        get => GetArgument<TerraformValue<string>>("chimesdkvoice");
        set => SetArgument("chimesdkvoice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cleanrooms
    {
        get => GetArgument<TerraformValue<string>>("cleanrooms");
        set => SetArgument("cleanrooms", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloud9
    {
        get => GetArgument<TerraformValue<string>>("cloud9");
        set => SetArgument("cloud9", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudcontrol
    {
        get => GetArgument<TerraformValue<string>>("cloudcontrol");
        set => SetArgument("cloudcontrol", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudcontrolapi
    {
        get => GetArgument<TerraformValue<string>>("cloudcontrolapi");
        set => SetArgument("cloudcontrolapi", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudformation
    {
        get => GetArgument<TerraformValue<string>>("cloudformation");
        set => SetArgument("cloudformation", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudfront
    {
        get => GetArgument<TerraformValue<string>>("cloudfront");
        set => SetArgument("cloudfront", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudfrontkeyvaluestore
    {
        get => GetArgument<TerraformValue<string>>("cloudfrontkeyvaluestore");
        set => SetArgument("cloudfrontkeyvaluestore", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudhsm
    {
        get => GetArgument<TerraformValue<string>>("cloudhsm");
        set => SetArgument("cloudhsm", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudhsmv2
    {
        get => GetArgument<TerraformValue<string>>("cloudhsmv2");
        set => SetArgument("cloudhsmv2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudsearch
    {
        get => GetArgument<TerraformValue<string>>("cloudsearch");
        set => SetArgument("cloudsearch", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudtrail
    {
        get => GetArgument<TerraformValue<string>>("cloudtrail");
        set => SetArgument("cloudtrail", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudwatch
    {
        get => GetArgument<TerraformValue<string>>("cloudwatch");
        set => SetArgument("cloudwatch", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudwatchevents
    {
        get => GetArgument<TerraformValue<string>>("cloudwatchevents");
        set => SetArgument("cloudwatchevents", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudwatchevidently
    {
        get => GetArgument<TerraformValue<string>>("cloudwatchevidently");
        set => SetArgument("cloudwatchevidently", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudwatchlog
    {
        get => GetArgument<TerraformValue<string>>("cloudwatchlog");
        set => SetArgument("cloudwatchlog", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudwatchlogs
    {
        get => GetArgument<TerraformValue<string>>("cloudwatchlogs");
        set => SetArgument("cloudwatchlogs", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudwatchobservabilityaccessmanager
    {
        get => GetArgument<TerraformValue<string>>("cloudwatchobservabilityaccessmanager");
        set => SetArgument("cloudwatchobservabilityaccessmanager", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cloudwatchrum
    {
        get => GetArgument<TerraformValue<string>>("cloudwatchrum");
        set => SetArgument("cloudwatchrum", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Codeartifact
    {
        get => GetArgument<TerraformValue<string>>("codeartifact");
        set => SetArgument("codeartifact", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Codebuild
    {
        get => GetArgument<TerraformValue<string>>("codebuild");
        set => SetArgument("codebuild", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Codecatalyst
    {
        get => GetArgument<TerraformValue<string>>("codecatalyst");
        set => SetArgument("codecatalyst", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Codecommit
    {
        get => GetArgument<TerraformValue<string>>("codecommit");
        set => SetArgument("codecommit", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Codeconnections
    {
        get => GetArgument<TerraformValue<string>>("codeconnections");
        set => SetArgument("codeconnections", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Codedeploy
    {
        get => GetArgument<TerraformValue<string>>("codedeploy");
        set => SetArgument("codedeploy", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Codeguruprofiler
    {
        get => GetArgument<TerraformValue<string>>("codeguruprofiler");
        set => SetArgument("codeguruprofiler", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Codegurureviewer
    {
        get => GetArgument<TerraformValue<string>>("codegurureviewer");
        set => SetArgument("codegurureviewer", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Codepipeline
    {
        get => GetArgument<TerraformValue<string>>("codepipeline");
        set => SetArgument("codepipeline", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Codestarconnections
    {
        get => GetArgument<TerraformValue<string>>("codestarconnections");
        set => SetArgument("codestarconnections", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Codestarnotifications
    {
        get => GetArgument<TerraformValue<string>>("codestarnotifications");
        set => SetArgument("codestarnotifications", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cognitoidentity
    {
        get => GetArgument<TerraformValue<string>>("cognitoidentity");
        set => SetArgument("cognitoidentity", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cognitoidentityprovider
    {
        get => GetArgument<TerraformValue<string>>("cognitoidentityprovider");
        set => SetArgument("cognitoidentityprovider", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cognitoidp
    {
        get => GetArgument<TerraformValue<string>>("cognitoidp");
        set => SetArgument("cognitoidp", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Comprehend
    {
        get => GetArgument<TerraformValue<string>>("comprehend");
        set => SetArgument("comprehend", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Computeoptimizer
    {
        get => GetArgument<TerraformValue<string>>("computeoptimizer");
        set => SetArgument("computeoptimizer", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Config
    {
        get => GetArgument<TerraformValue<string>>("config");
        set => SetArgument("config", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Configservice
    {
        get => GetArgument<TerraformValue<string>>("configservice");
        set => SetArgument("configservice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Connect
    {
        get => GetArgument<TerraformValue<string>>("connect");
        set => SetArgument("connect", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Connectcases
    {
        get => GetArgument<TerraformValue<string>>("connectcases");
        set => SetArgument("connectcases", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Controltower
    {
        get => GetArgument<TerraformValue<string>>("controltower");
        set => SetArgument("controltower", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Costandusagereportservice
    {
        get => GetArgument<TerraformValue<string>>("costandusagereportservice");
        set => SetArgument("costandusagereportservice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Costexplorer
    {
        get => GetArgument<TerraformValue<string>>("costexplorer");
        set => SetArgument("costexplorer", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Costoptimizationhub
    {
        get => GetArgument<TerraformValue<string>>("costoptimizationhub");
        set => SetArgument("costoptimizationhub", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Cur
    {
        get => GetArgument<TerraformValue<string>>("cur");
        set => SetArgument("cur", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Customerprofiles
    {
        get => GetArgument<TerraformValue<string>>("customerprofiles");
        set => SetArgument("customerprofiles", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Databasemigration
    {
        get => GetArgument<TerraformValue<string>>("databasemigration");
        set => SetArgument("databasemigration", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Databasemigrationservice
    {
        get => GetArgument<TerraformValue<string>>("databasemigrationservice");
        set => SetArgument("databasemigrationservice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Databrew
    {
        get => GetArgument<TerraformValue<string>>("databrew");
        set => SetArgument("databrew", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Dataexchange
    {
        get => GetArgument<TerraformValue<string>>("dataexchange");
        set => SetArgument("dataexchange", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Datapipeline
    {
        get => GetArgument<TerraformValue<string>>("datapipeline");
        set => SetArgument("datapipeline", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Datasync
    {
        get => GetArgument<TerraformValue<string>>("datasync");
        set => SetArgument("datasync", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Datazone
    {
        get => GetArgument<TerraformValue<string>>("datazone");
        set => SetArgument("datazone", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Dax
    {
        get => GetArgument<TerraformValue<string>>("dax");
        set => SetArgument("dax", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Deploy
    {
        get => GetArgument<TerraformValue<string>>("deploy");
        set => SetArgument("deploy", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Detective
    {
        get => GetArgument<TerraformValue<string>>("detective");
        set => SetArgument("detective", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Devicefarm
    {
        get => GetArgument<TerraformValue<string>>("devicefarm");
        set => SetArgument("devicefarm", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Devopsguru
    {
        get => GetArgument<TerraformValue<string>>("devopsguru");
        set => SetArgument("devopsguru", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Directconnect
    {
        get => GetArgument<TerraformValue<string>>("directconnect");
        set => SetArgument("directconnect", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Directoryservice
    {
        get => GetArgument<TerraformValue<string>>("directoryservice");
        set => SetArgument("directoryservice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Dlm
    {
        get => GetArgument<TerraformValue<string>>("dlm");
        set => SetArgument("dlm", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Dms
    {
        get => GetArgument<TerraformValue<string>>("dms");
        set => SetArgument("dms", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Docdb
    {
        get => GetArgument<TerraformValue<string>>("docdb");
        set => SetArgument("docdb", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Docdbelastic
    {
        get => GetArgument<TerraformValue<string>>("docdbelastic");
        set => SetArgument("docdbelastic", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Drs
    {
        get => GetArgument<TerraformValue<string>>("drs");
        set => SetArgument("drs", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ds
    {
        get => GetArgument<TerraformValue<string>>("ds");
        set => SetArgument("ds", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Dsql
    {
        get => GetArgument<TerraformValue<string>>("dsql");
        set => SetArgument("dsql", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Dynamodb
    {
        get => GetArgument<TerraformValue<string>>("dynamodb");
        set => SetArgument("dynamodb", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ec2
    {
        get => GetArgument<TerraformValue<string>>("ec2");
        set => SetArgument("ec2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ecr
    {
        get => GetArgument<TerraformValue<string>>("ecr");
        set => SetArgument("ecr", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ecrpublic
    {
        get => GetArgument<TerraformValue<string>>("ecrpublic");
        set => SetArgument("ecrpublic", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ecs
    {
        get => GetArgument<TerraformValue<string>>("ecs");
        set => SetArgument("ecs", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Efs
    {
        get => GetArgument<TerraformValue<string>>("efs");
        set => SetArgument("efs", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Eks
    {
        get => GetArgument<TerraformValue<string>>("eks");
        set => SetArgument("eks", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Elasticache
    {
        get => GetArgument<TerraformValue<string>>("elasticache");
        set => SetArgument("elasticache", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Elasticbeanstalk
    {
        get => GetArgument<TerraformValue<string>>("elasticbeanstalk");
        set => SetArgument("elasticbeanstalk", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Elasticloadbalancing
    {
        get => GetArgument<TerraformValue<string>>("elasticloadbalancing");
        set => SetArgument("elasticloadbalancing", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Elasticloadbalancingv2
    {
        get => GetArgument<TerraformValue<string>>("elasticloadbalancingv2");
        set => SetArgument("elasticloadbalancingv2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Elasticsearch
    {
        get => GetArgument<TerraformValue<string>>("elasticsearch");
        set => SetArgument("elasticsearch", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Elasticsearchservice
    {
        get => GetArgument<TerraformValue<string>>("elasticsearchservice");
        set => SetArgument("elasticsearchservice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Elastictranscoder
    {
        get => GetArgument<TerraformValue<string>>("elastictranscoder");
        set => SetArgument("elastictranscoder", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Elb
    {
        get => GetArgument<TerraformValue<string>>("elb");
        set => SetArgument("elb", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Elbv2
    {
        get => GetArgument<TerraformValue<string>>("elbv2");
        set => SetArgument("elbv2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Emr
    {
        get => GetArgument<TerraformValue<string>>("emr");
        set => SetArgument("emr", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Emrcontainers
    {
        get => GetArgument<TerraformValue<string>>("emrcontainers");
        set => SetArgument("emrcontainers", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Emrserverless
    {
        get => GetArgument<TerraformValue<string>>("emrserverless");
        set => SetArgument("emrserverless", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Es
    {
        get => GetArgument<TerraformValue<string>>("es");
        set => SetArgument("es", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Eventbridge
    {
        get => GetArgument<TerraformValue<string>>("eventbridge");
        set => SetArgument("eventbridge", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Events
    {
        get => GetArgument<TerraformValue<string>>("events");
        set => SetArgument("events", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Evidently
    {
        get => GetArgument<TerraformValue<string>>("evidently");
        set => SetArgument("evidently", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Evs
    {
        get => GetArgument<TerraformValue<string>>("evs");
        set => SetArgument("evs", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Finspace
    {
        get => GetArgument<TerraformValue<string>>("finspace");
        set => SetArgument("finspace", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Firehose
    {
        get => GetArgument<TerraformValue<string>>("firehose");
        set => SetArgument("firehose", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Fis
    {
        get => GetArgument<TerraformValue<string>>("fis");
        set => SetArgument("fis", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Fms
    {
        get => GetArgument<TerraformValue<string>>("fms");
        set => SetArgument("fms", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Fsx
    {
        get => GetArgument<TerraformValue<string>>("fsx");
        set => SetArgument("fsx", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Gamelift
    {
        get => GetArgument<TerraformValue<string>>("gamelift");
        set => SetArgument("gamelift", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Glacier
    {
        get => GetArgument<TerraformValue<string>>("glacier");
        set => SetArgument("glacier", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Globalaccelerator
    {
        get => GetArgument<TerraformValue<string>>("globalaccelerator");
        set => SetArgument("globalaccelerator", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Glue
    {
        get => GetArgument<TerraformValue<string>>("glue");
        set => SetArgument("glue", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Gluedatabrew
    {
        get => GetArgument<TerraformValue<string>>("gluedatabrew");
        set => SetArgument("gluedatabrew", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Grafana
    {
        get => GetArgument<TerraformValue<string>>("grafana");
        set => SetArgument("grafana", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Greengrass
    {
        get => GetArgument<TerraformValue<string>>("greengrass");
        set => SetArgument("greengrass", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Groundstation
    {
        get => GetArgument<TerraformValue<string>>("groundstation");
        set => SetArgument("groundstation", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Guardduty
    {
        get => GetArgument<TerraformValue<string>>("guardduty");
        set => SetArgument("guardduty", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Healthlake
    {
        get => GetArgument<TerraformValue<string>>("healthlake");
        set => SetArgument("healthlake", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Iam
    {
        get => GetArgument<TerraformValue<string>>("iam");
        set => SetArgument("iam", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Identitystore
    {
        get => GetArgument<TerraformValue<string>>("identitystore");
        set => SetArgument("identitystore", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Imagebuilder
    {
        get => GetArgument<TerraformValue<string>>("imagebuilder");
        set => SetArgument("imagebuilder", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Inspector
    {
        get => GetArgument<TerraformValue<string>>("inspector");
        set => SetArgument("inspector", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Inspector2
    {
        get => GetArgument<TerraformValue<string>>("inspector2");
        set => SetArgument("inspector2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Inspectorv2
    {
        get => GetArgument<TerraformValue<string>>("inspectorv2");
        set => SetArgument("inspectorv2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Internetmonitor
    {
        get => GetArgument<TerraformValue<string>>("internetmonitor");
        set => SetArgument("internetmonitor", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Invoicing
    {
        get => GetArgument<TerraformValue<string>>("invoicing");
        set => SetArgument("invoicing", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Iot
    {
        get => GetArgument<TerraformValue<string>>("iot");
        set => SetArgument("iot", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ivs
    {
        get => GetArgument<TerraformValue<string>>("ivs");
        set => SetArgument("ivs", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ivschat
    {
        get => GetArgument<TerraformValue<string>>("ivschat");
        set => SetArgument("ivschat", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Kafka
    {
        get => GetArgument<TerraformValue<string>>("kafka");
        set => SetArgument("kafka", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Kafkaconnect
    {
        get => GetArgument<TerraformValue<string>>("kafkaconnect");
        set => SetArgument("kafkaconnect", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Kendra
    {
        get => GetArgument<TerraformValue<string>>("kendra");
        set => SetArgument("kendra", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Keyspaces
    {
        get => GetArgument<TerraformValue<string>>("keyspaces");
        set => SetArgument("keyspaces", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Kinesis
    {
        get => GetArgument<TerraformValue<string>>("kinesis");
        set => SetArgument("kinesis", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Kinesisanalytics
    {
        get => GetArgument<TerraformValue<string>>("kinesisanalytics");
        set => SetArgument("kinesisanalytics", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Kinesisanalyticsv2
    {
        get => GetArgument<TerraformValue<string>>("kinesisanalyticsv2");
        set => SetArgument("kinesisanalyticsv2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Kinesisvideo
    {
        get => GetArgument<TerraformValue<string>>("kinesisvideo");
        set => SetArgument("kinesisvideo", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Kms
    {
        get => GetArgument<TerraformValue<string>>("kms");
        set => SetArgument("kms", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Lakeformation
    {
        get => GetArgument<TerraformValue<string>>("lakeformation");
        set => SetArgument("lakeformation", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Lambda
    {
        get => GetArgument<TerraformValue<string>>("lambda");
        set => SetArgument("lambda", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Launchwizard
    {
        get => GetArgument<TerraformValue<string>>("launchwizard");
        set => SetArgument("launchwizard", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Lex
    {
        get => GetArgument<TerraformValue<string>>("lex");
        set => SetArgument("lex", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Lexmodelbuilding
    {
        get => GetArgument<TerraformValue<string>>("lexmodelbuilding");
        set => SetArgument("lexmodelbuilding", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Lexmodelbuildingservice
    {
        get => GetArgument<TerraformValue<string>>("lexmodelbuildingservice");
        set => SetArgument("lexmodelbuildingservice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Lexmodels
    {
        get => GetArgument<TerraformValue<string>>("lexmodels");
        set => SetArgument("lexmodels", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Lexmodelsv2
    {
        get => GetArgument<TerraformValue<string>>("lexmodelsv2");
        set => SetArgument("lexmodelsv2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Lexv2models
    {
        get => GetArgument<TerraformValue<string>>("lexv2models");
        set => SetArgument("lexv2models", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Licensemanager
    {
        get => GetArgument<TerraformValue<string>>("licensemanager");
        set => SetArgument("licensemanager", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Lightsail
    {
        get => GetArgument<TerraformValue<string>>("lightsail");
        set => SetArgument("lightsail", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Locationservice
    {
        get => GetArgument<TerraformValue<string>>("locationservice");
        set => SetArgument("locationservice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Logs
    {
        get => GetArgument<TerraformValue<string>>("logs");
        set => SetArgument("logs", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Lookoutmetrics
    {
        get => GetArgument<TerraformValue<string>>("lookoutmetrics");
        set => SetArgument("lookoutmetrics", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? M2
    {
        get => GetArgument<TerraformValue<string>>("m2");
        set => SetArgument("m2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Macie2
    {
        get => GetArgument<TerraformValue<string>>("macie2");
        set => SetArgument("macie2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Managedgrafana
    {
        get => GetArgument<TerraformValue<string>>("managedgrafana");
        set => SetArgument("managedgrafana", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Mediaconnect
    {
        get => GetArgument<TerraformValue<string>>("mediaconnect");
        set => SetArgument("mediaconnect", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Mediaconvert
    {
        get => GetArgument<TerraformValue<string>>("mediaconvert");
        set => SetArgument("mediaconvert", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Medialive
    {
        get => GetArgument<TerraformValue<string>>("medialive");
        set => SetArgument("medialive", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Mediapackage
    {
        get => GetArgument<TerraformValue<string>>("mediapackage");
        set => SetArgument("mediapackage", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Mediapackagev2
    {
        get => GetArgument<TerraformValue<string>>("mediapackagev2");
        set => SetArgument("mediapackagev2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Mediapackagevod
    {
        get => GetArgument<TerraformValue<string>>("mediapackagevod");
        set => SetArgument("mediapackagevod", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Mediastore
    {
        get => GetArgument<TerraformValue<string>>("mediastore");
        set => SetArgument("mediastore", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Memorydb
    {
        get => GetArgument<TerraformValue<string>>("memorydb");
        set => SetArgument("memorydb", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Mgn
    {
        get => GetArgument<TerraformValue<string>>("mgn");
        set => SetArgument("mgn", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Mq
    {
        get => GetArgument<TerraformValue<string>>("mq");
        set => SetArgument("mq", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Msk
    {
        get => GetArgument<TerraformValue<string>>("msk");
        set => SetArgument("msk", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Mwaa
    {
        get => GetArgument<TerraformValue<string>>("mwaa");
        set => SetArgument("mwaa", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Neptune
    {
        get => GetArgument<TerraformValue<string>>("neptune");
        set => SetArgument("neptune", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Neptunegraph
    {
        get => GetArgument<TerraformValue<string>>("neptunegraph");
        set => SetArgument("neptunegraph", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Networkfirewall
    {
        get => GetArgument<TerraformValue<string>>("networkfirewall");
        set => SetArgument("networkfirewall", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Networkflowmonitor
    {
        get => GetArgument<TerraformValue<string>>("networkflowmonitor");
        set => SetArgument("networkflowmonitor", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Networkmanager
    {
        get => GetArgument<TerraformValue<string>>("networkmanager");
        set => SetArgument("networkmanager", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Networkmonitor
    {
        get => GetArgument<TerraformValue<string>>("networkmonitor");
        set => SetArgument("networkmonitor", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Notifications
    {
        get => GetArgument<TerraformValue<string>>("notifications");
        set => SetArgument("notifications", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Notificationscontacts
    {
        get => GetArgument<TerraformValue<string>>("notificationscontacts");
        set => SetArgument("notificationscontacts", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Oam
    {
        get => GetArgument<TerraformValue<string>>("oam");
        set => SetArgument("oam", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Observabilityadmin
    {
        get => GetArgument<TerraformValue<string>>("observabilityadmin");
        set => SetArgument("observabilityadmin", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Odb
    {
        get => GetArgument<TerraformValue<string>>("odb");
        set => SetArgument("odb", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Opensearch
    {
        get => GetArgument<TerraformValue<string>>("opensearch");
        set => SetArgument("opensearch", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Opensearchingestion
    {
        get => GetArgument<TerraformValue<string>>("opensearchingestion");
        set => SetArgument("opensearchingestion", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Opensearchserverless
    {
        get => GetArgument<TerraformValue<string>>("opensearchserverless");
        set => SetArgument("opensearchserverless", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Opensearchservice
    {
        get => GetArgument<TerraformValue<string>>("opensearchservice");
        set => SetArgument("opensearchservice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Organizations
    {
        get => GetArgument<TerraformValue<string>>("organizations");
        set => SetArgument("organizations", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Osis
    {
        get => GetArgument<TerraformValue<string>>("osis");
        set => SetArgument("osis", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Outposts
    {
        get => GetArgument<TerraformValue<string>>("outposts");
        set => SetArgument("outposts", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Paymentcryptography
    {
        get => GetArgument<TerraformValue<string>>("paymentcryptography");
        set => SetArgument("paymentcryptography", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Pcaconnectorad
    {
        get => GetArgument<TerraformValue<string>>("pcaconnectorad");
        set => SetArgument("pcaconnectorad", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Pcs
    {
        get => GetArgument<TerraformValue<string>>("pcs");
        set => SetArgument("pcs", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Pinpoint
    {
        get => GetArgument<TerraformValue<string>>("pinpoint");
        set => SetArgument("pinpoint", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Pinpointsmsvoicev2
    {
        get => GetArgument<TerraformValue<string>>("pinpointsmsvoicev2");
        set => SetArgument("pinpointsmsvoicev2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Pipes
    {
        get => GetArgument<TerraformValue<string>>("pipes");
        set => SetArgument("pipes", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Polly
    {
        get => GetArgument<TerraformValue<string>>("polly");
        set => SetArgument("polly", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Pricing
    {
        get => GetArgument<TerraformValue<string>>("pricing");
        set => SetArgument("pricing", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Prometheus
    {
        get => GetArgument<TerraformValue<string>>("prometheus");
        set => SetArgument("prometheus", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Prometheusservice
    {
        get => GetArgument<TerraformValue<string>>("prometheusservice");
        set => SetArgument("prometheusservice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Qbusiness
    {
        get => GetArgument<TerraformValue<string>>("qbusiness");
        set => SetArgument("qbusiness", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Qldb
    {
        get => GetArgument<TerraformValue<string>>("qldb");
        set => SetArgument("qldb", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Quicksight
    {
        get => GetArgument<TerraformValue<string>>("quicksight");
        set => SetArgument("quicksight", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ram
    {
        get => GetArgument<TerraformValue<string>>("ram");
        set => SetArgument("ram", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Rbin
    {
        get => GetArgument<TerraformValue<string>>("rbin");
        set => SetArgument("rbin", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Rds
    {
        get => GetArgument<TerraformValue<string>>("rds");
        set => SetArgument("rds", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Recyclebin
    {
        get => GetArgument<TerraformValue<string>>("recyclebin");
        set => SetArgument("recyclebin", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Redshift
    {
        get => GetArgument<TerraformValue<string>>("redshift");
        set => SetArgument("redshift", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Redshiftdata
    {
        get => GetArgument<TerraformValue<string>>("redshiftdata");
        set => SetArgument("redshiftdata", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Redshiftdataapiservice
    {
        get => GetArgument<TerraformValue<string>>("redshiftdataapiservice");
        set => SetArgument("redshiftdataapiservice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Redshiftserverless
    {
        get => GetArgument<TerraformValue<string>>("redshiftserverless");
        set => SetArgument("redshiftserverless", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Rekognition
    {
        get => GetArgument<TerraformValue<string>>("rekognition");
        set => SetArgument("rekognition", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Resiliencehub
    {
        get => GetArgument<TerraformValue<string>>("resiliencehub");
        set => SetArgument("resiliencehub", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Resourceexplorer2
    {
        get => GetArgument<TerraformValue<string>>("resourceexplorer2");
        set => SetArgument("resourceexplorer2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Resourcegroups
    {
        get => GetArgument<TerraformValue<string>>("resourcegroups");
        set => SetArgument("resourcegroups", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Resourcegroupstagging
    {
        get => GetArgument<TerraformValue<string>>("resourcegroupstagging");
        set => SetArgument("resourcegroupstagging", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Resourcegroupstaggingapi
    {
        get => GetArgument<TerraformValue<string>>("resourcegroupstaggingapi");
        set => SetArgument("resourcegroupstaggingapi", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Rolesanywhere
    {
        get => GetArgument<TerraformValue<string>>("rolesanywhere");
        set => SetArgument("rolesanywhere", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Route53
    {
        get => GetArgument<TerraformValue<string>>("route53");
        set => SetArgument("route53", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Route53domains
    {
        get => GetArgument<TerraformValue<string>>("route53domains");
        set => SetArgument("route53domains", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Route53profiles
    {
        get => GetArgument<TerraformValue<string>>("route53profiles");
        set => SetArgument("route53profiles", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Route53recoverycontrolconfig
    {
        get => GetArgument<TerraformValue<string>>("route53recoverycontrolconfig");
        set => SetArgument("route53recoverycontrolconfig", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Route53recoveryreadiness
    {
        get => GetArgument<TerraformValue<string>>("route53recoveryreadiness");
        set => SetArgument("route53recoveryreadiness", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Route53resolver
    {
        get => GetArgument<TerraformValue<string>>("route53resolver");
        set => SetArgument("route53resolver", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Rum
    {
        get => GetArgument<TerraformValue<string>>("rum");
        set => SetArgument("rum", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? S3
    {
        get => GetArgument<TerraformValue<string>>("s3");
        set => SetArgument("s3", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? S3api
    {
        get => GetArgument<TerraformValue<string>>("s3api");
        set => SetArgument("s3api", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? S3control
    {
        get => GetArgument<TerraformValue<string>>("s3control");
        set => SetArgument("s3control", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? S3outposts
    {
        get => GetArgument<TerraformValue<string>>("s3outposts");
        set => SetArgument("s3outposts", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? S3tables
    {
        get => GetArgument<TerraformValue<string>>("s3tables");
        set => SetArgument("s3tables", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? S3vectors
    {
        get => GetArgument<TerraformValue<string>>("s3vectors");
        set => SetArgument("s3vectors", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Sagemaker
    {
        get => GetArgument<TerraformValue<string>>("sagemaker");
        set => SetArgument("sagemaker", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Scheduler
    {
        get => GetArgument<TerraformValue<string>>("scheduler");
        set => SetArgument("scheduler", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Schemas
    {
        get => GetArgument<TerraformValue<string>>("schemas");
        set => SetArgument("schemas", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Secretsmanager
    {
        get => GetArgument<TerraformValue<string>>("secretsmanager");
        set => SetArgument("secretsmanager", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Securityhub
    {
        get => GetArgument<TerraformValue<string>>("securityhub");
        set => SetArgument("securityhub", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Securitylake
    {
        get => GetArgument<TerraformValue<string>>("securitylake");
        set => SetArgument("securitylake", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Serverlessapplicationrepository
    {
        get => GetArgument<TerraformValue<string>>("serverlessapplicationrepository");
        set => SetArgument("serverlessapplicationrepository", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Serverlessapprepo
    {
        get => GetArgument<TerraformValue<string>>("serverlessapprepo");
        set => SetArgument("serverlessapprepo", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Serverlessrepo
    {
        get => GetArgument<TerraformValue<string>>("serverlessrepo");
        set => SetArgument("serverlessrepo", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Servicecatalog
    {
        get => GetArgument<TerraformValue<string>>("servicecatalog");
        set => SetArgument("servicecatalog", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Servicecatalogappregistry
    {
        get => GetArgument<TerraformValue<string>>("servicecatalogappregistry");
        set => SetArgument("servicecatalogappregistry", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Servicediscovery
    {
        get => GetArgument<TerraformValue<string>>("servicediscovery");
        set => SetArgument("servicediscovery", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Servicequotas
    {
        get => GetArgument<TerraformValue<string>>("servicequotas");
        set => SetArgument("servicequotas", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ses
    {
        get => GetArgument<TerraformValue<string>>("ses");
        set => SetArgument("ses", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Sesv2
    {
        get => GetArgument<TerraformValue<string>>("sesv2");
        set => SetArgument("sesv2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Sfn
    {
        get => GetArgument<TerraformValue<string>>("sfn");
        set => SetArgument("sfn", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Shield
    {
        get => GetArgument<TerraformValue<string>>("shield");
        set => SetArgument("shield", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Signer
    {
        get => GetArgument<TerraformValue<string>>("signer");
        set => SetArgument("signer", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Sns
    {
        get => GetArgument<TerraformValue<string>>("sns");
        set => SetArgument("sns", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Sqs
    {
        get => GetArgument<TerraformValue<string>>("sqs");
        set => SetArgument("sqs", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ssm
    {
        get => GetArgument<TerraformValue<string>>("ssm");
        set => SetArgument("ssm", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ssmcontacts
    {
        get => GetArgument<TerraformValue<string>>("ssmcontacts");
        set => SetArgument("ssmcontacts", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ssmincidents
    {
        get => GetArgument<TerraformValue<string>>("ssmincidents");
        set => SetArgument("ssmincidents", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ssmquicksetup
    {
        get => GetArgument<TerraformValue<string>>("ssmquicksetup");
        set => SetArgument("ssmquicksetup", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ssmsap
    {
        get => GetArgument<TerraformValue<string>>("ssmsap");
        set => SetArgument("ssmsap", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Sso
    {
        get => GetArgument<TerraformValue<string>>("sso");
        set => SetArgument("sso", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Ssoadmin
    {
        get => GetArgument<TerraformValue<string>>("ssoadmin");
        set => SetArgument("ssoadmin", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Stepfunctions
    {
        get => GetArgument<TerraformValue<string>>("stepfunctions");
        set => SetArgument("stepfunctions", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Storagegateway
    {
        get => GetArgument<TerraformValue<string>>("storagegateway");
        set => SetArgument("storagegateway", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Sts
    {
        get => GetArgument<TerraformValue<string>>("sts");
        set => SetArgument("sts", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Swf
    {
        get => GetArgument<TerraformValue<string>>("swf");
        set => SetArgument("swf", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Synthetics
    {
        get => GetArgument<TerraformValue<string>>("synthetics");
        set => SetArgument("synthetics", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Taxsettings
    {
        get => GetArgument<TerraformValue<string>>("taxsettings");
        set => SetArgument("taxsettings", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Timestreaminfluxdb
    {
        get => GetArgument<TerraformValue<string>>("timestreaminfluxdb");
        set => SetArgument("timestreaminfluxdb", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Timestreamquery
    {
        get => GetArgument<TerraformValue<string>>("timestreamquery");
        set => SetArgument("timestreamquery", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Timestreamwrite
    {
        get => GetArgument<TerraformValue<string>>("timestreamwrite");
        set => SetArgument("timestreamwrite", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Transcribe
    {
        get => GetArgument<TerraformValue<string>>("transcribe");
        set => SetArgument("transcribe", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Transcribeservice
    {
        get => GetArgument<TerraformValue<string>>("transcribeservice");
        set => SetArgument("transcribeservice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Transfer
    {
        get => GetArgument<TerraformValue<string>>("transfer");
        set => SetArgument("transfer", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Verifiedpermissions
    {
        get => GetArgument<TerraformValue<string>>("verifiedpermissions");
        set => SetArgument("verifiedpermissions", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Vpclattice
    {
        get => GetArgument<TerraformValue<string>>("vpclattice");
        set => SetArgument("vpclattice", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Waf
    {
        get => GetArgument<TerraformValue<string>>("waf");
        set => SetArgument("waf", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Wafregional
    {
        get => GetArgument<TerraformValue<string>>("wafregional");
        set => SetArgument("wafregional", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Wafv2
    {
        get => GetArgument<TerraformValue<string>>("wafv2");
        set => SetArgument("wafv2", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Wellarchitected
    {
        get => GetArgument<TerraformValue<string>>("wellarchitected");
        set => SetArgument("wellarchitected", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Workmail
    {
        get => GetArgument<TerraformValue<string>>("workmail");
        set => SetArgument("workmail", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Workspaces
    {
        get => GetArgument<TerraformValue<string>>("workspaces");
        set => SetArgument("workspaces", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Workspacesweb
    {
        get => GetArgument<TerraformValue<string>>("workspacesweb");
        set => SetArgument("workspacesweb", value);
    }

    /// <summary>
    /// Use this to override the default service endpoint URL
    /// </summary>
    public TerraformValue<string>? Xray
    {
        get => GetArgument<TerraformValue<string>>("xray");
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
        get => GetArgument<TerraformSet<string>>("key_prefixes");
        set => SetArgument("key_prefixes", value);
    }

    /// <summary>
    /// Resource tag keys to ignore across all resources. Can also be configured with the TF_AWS_IGNORE_TAGS_KEYS environment variable.
    /// </summary>
    public TerraformSet<string>? KeysAttribute
    {
        get => GetArgument<TerraformSet<string>>("keys");
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
        get => GetArgument<TerraformValue<string>>("access_key");
        set => SetArgument("access_key", value);
    }


    /// <summary>
    /// The allowed_account_ids attribute.
    /// </summary>
    public TerraformSet<string>? AllowedAccountIds
    {
        get => GetArgument<TerraformSet<string>>("allowed_account_ids");
        set => SetArgument("allowed_account_ids", value);
    }


    /// <summary>
    /// File containing custom root and intermediate certificates. Can also be configured using the `AWS_CA_BUNDLE` environment variable. (Setting `ca_bundle` in the shared config file is not supported.)
    /// </summary>
    public TerraformValue<string>? CustomCaBundle
    {
        get => GetArgument<TerraformValue<string>>("custom_ca_bundle");
        set => SetArgument("custom_ca_bundle", value);
    }


    /// <summary>
    /// Address of the EC2 metadata service endpoint to use. Can also be configured using the `AWS_EC2_METADATA_SERVICE_ENDPOINT` environment variable.
    /// </summary>
    public TerraformValue<string>? Ec2MetadataServiceEndpoint
    {
        get => GetArgument<TerraformValue<string>>("ec2_metadata_service_endpoint");
        set => SetArgument("ec2_metadata_service_endpoint", value);
    }


    /// <summary>
    /// Protocol to use with EC2 metadata service endpoint.Valid values are `IPv4` and `IPv6`. Can also be configured using the `AWS_EC2_METADATA_SERVICE_ENDPOINT_MODE` environment variable.
    /// </summary>
    public TerraformValue<string>? Ec2MetadataServiceEndpointMode
    {
        get => GetArgument<TerraformValue<string>>("ec2_metadata_service_endpoint_mode");
        set => SetArgument("ec2_metadata_service_endpoint_mode", value);
    }


    /// <summary>
    /// The forbidden_account_ids attribute.
    /// </summary>
    public TerraformSet<string>? ForbiddenAccountIds
    {
        get => GetArgument<TerraformSet<string>>("forbidden_account_ids");
        set => SetArgument("forbidden_account_ids", value);
    }


    /// <summary>
    /// URL of a proxy to use for HTTP requests when accessing the AWS API. Can also be set using the `HTTP_PROXY` or `http_proxy` environment variables.
    /// </summary>
    public TerraformValue<string>? HttpProxy
    {
        get => GetArgument<TerraformValue<string>>("http_proxy");
        set => SetArgument("http_proxy", value);
    }


    /// <summary>
    /// URL of a proxy to use for HTTPS requests when accessing the AWS API. Can also be set using the `HTTPS_PROXY` or `https_proxy` environment variables.
    /// </summary>
    public TerraformValue<string>? HttpsProxy
    {
        get => GetArgument<TerraformValue<string>>("https_proxy");
        set => SetArgument("https_proxy", value);
    }


    /// <summary>
    /// Explicitly allow the provider to perform &amp;quot;insecure&amp;quot; SSL requests. If omitted, default value is `false`
    /// </summary>
    public TerraformValue<bool>? Insecure
    {
        get => GetArgument<TerraformValue<bool>>("insecure");
        set => SetArgument("insecure", value);
    }


    /// <summary>
    /// The maximum number of times an AWS API request is
    /// being executed. If the API request still fails, an error is
    /// thrown.
    /// </summary>
    public TerraformValue<double>? MaxRetries
    {
        get => GetArgument<TerraformValue<double>>("max_retries");
        set => SetArgument("max_retries", value);
    }


    /// <summary>
    /// Comma-separated list of hosts that should not use HTTP or HTTPS proxies. Can also be set using the `NO_PROXY` or `no_proxy` environment variables.
    /// </summary>
    public TerraformValue<string>? NoProxy
    {
        get => GetArgument<TerraformValue<string>>("no_proxy");
        set => SetArgument("no_proxy", value);
    }


    /// <summary>
    /// The profile for API operations. If not set, the default profile
    /// created with `aws configure` will be used.
    /// </summary>
    public TerraformValue<string>? Profile
    {
        get => GetArgument<TerraformValue<string>>("profile");
        set => SetArgument("profile", value);
    }


    /// <summary>
    /// The region where AWS operations will take place. Examples
    /// are us-east-1, us-west-2, etc.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }


    /// <summary>
    /// Specifies how retries are attempted. Valid values are `standard` and `adaptive`. Can also be configured using the `AWS_RETRY_MODE` environment variable.
    /// </summary>
    public TerraformValue<string>? RetryMode
    {
        get => GetArgument<TerraformValue<string>>("retry_mode");
        set => SetArgument("retry_mode", value);
    }


    /// <summary>
    /// Specifies whether S3 API calls in the `us-east-1` region use the legacy global endpoint or a regional endpoint. Valid values are `legacy` or `regional`. Can also be configured using the `AWS_S3_US_EAST_1_REGIONAL_ENDPOINT` environment variable or the `s3_us_east_1_regional_endpoint` shared config file parameter
    /// </summary>
    public TerraformValue<string>? S3UsEast1RegionalEndpoint
    {
        get => GetArgument<TerraformValue<string>>("s3_us_east_1_regional_endpoint");
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
        get => GetArgument<TerraformValue<bool>>("s3_use_path_style");
        set => SetArgument("s3_use_path_style", value);
    }


    /// <summary>
    /// The secret key for API operations. You can retrieve this
    /// from the &#39;Security &amp;amp; Credentials&#39; section of the AWS console.
    /// </summary>
    public TerraformValue<string>? SecretKey
    {
        get => GetArgument<TerraformValue<string>>("secret_key");
        set => SetArgument("secret_key", value);
    }


    /// <summary>
    /// List of paths to shared config files. If not set, defaults to [~/.aws/config].
    /// </summary>
    public TerraformList<string>? SharedConfigFiles
    {
        get => GetArgument<TerraformList<string>>("shared_config_files");
        set => SetArgument("shared_config_files", value);
    }


    /// <summary>
    /// List of paths to shared credentials files. If not set, defaults to [~/.aws/credentials].
    /// </summary>
    public TerraformList<string>? SharedCredentialsFiles
    {
        get => GetArgument<TerraformList<string>>("shared_credentials_files");
        set => SetArgument("shared_credentials_files", value);
    }


    /// <summary>
    /// Skip the credentials validation via STS API. Used for AWS API implementations that do not have STS available/implemented.
    /// </summary>
    public TerraformValue<bool>? SkipCredentialsValidation
    {
        get => GetArgument<TerraformValue<bool>>("skip_credentials_validation");
        set => SetArgument("skip_credentials_validation", value);
    }


    /// <summary>
    /// Skip the AWS Metadata API check. Used for AWS API implementations that do not have a metadata api endpoint.
    /// </summary>
    public TerraformValue<string>? SkipMetadataApiCheck
    {
        get => GetArgument<TerraformValue<string>>("skip_metadata_api_check");
        set => SetArgument("skip_metadata_api_check", value);
    }


    /// <summary>
    /// Skip static validation of region name. Used by users of alternative AWS-like APIs or users w/ access to regions that are not public (yet).
    /// </summary>
    public TerraformValue<bool>? SkipRegionValidation
    {
        get => GetArgument<TerraformValue<bool>>("skip_region_validation");
        set => SetArgument("skip_region_validation", value);
    }


    /// <summary>
    /// Skip requesting the account ID. Used for AWS API implementations that do not have IAM/STS API and/or metadata API.
    /// </summary>
    public TerraformValue<bool>? SkipRequestingAccountId
    {
        get => GetArgument<TerraformValue<bool>>("skip_requesting_account_id");
        set => SetArgument("skip_requesting_account_id", value);
    }


    /// <summary>
    /// The region where AWS STS operations will take place. Examples
    /// are us-east-1 and us-west-2.
    /// </summary>
    public TerraformValue<string>? StsRegion
    {
        get => GetArgument<TerraformValue<string>>("sts_region");
        set => SetArgument("sts_region", value);
    }


    /// <summary>
    /// session token. A session token is only required if you are
    /// using temporary security credentials.
    /// </summary>
    public TerraformValue<string>? Token
    {
        get => GetArgument<TerraformValue<string>>("token");
        set => SetArgument("token", value);
    }


    /// <summary>
    /// The capacity of the AWS SDK&#39;s token bucket rate limiter.
    /// </summary>
    public TerraformValue<double>? TokenBucketRateLimiterCapacity
    {
        get => GetArgument<TerraformValue<double>>("token_bucket_rate_limiter_capacity");
        set => SetArgument("token_bucket_rate_limiter_capacity", value);
    }


    /// <summary>
    /// Resolve an endpoint with DualStack capability
    /// </summary>
    public TerraformValue<bool>? UseDualstackEndpoint
    {
        get => GetArgument<TerraformValue<bool>>("use_dualstack_endpoint");
        set => SetArgument("use_dualstack_endpoint", value);
    }


    /// <summary>
    /// Resolve an endpoint with FIPS capability
    /// </summary>
    public TerraformValue<bool>? UseFipsEndpoint
    {
        get => GetArgument<TerraformValue<bool>>("use_fips_endpoint");
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
